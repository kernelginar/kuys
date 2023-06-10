#!/usr/bin/env python3

"""
Yapımcı: Kernelginar <https://github.com/kernelginar>
Lisans Türü: GPLv2
"""

import sys
from os.path import dirname
from os import chdir
chdir(dirname(__file__))

from utils import kutuphane, kitap, zaman

from PyQt5 import QtGui
from PyQt5.uic import loadUi
from PyQt5.QtWidgets import QMainWindow, QApplication, QTableWidgetItem, QHeaderView

import sqlite3 as sql
database = sql.connect("./database/kutuphane.db")
db_cursor = database.cursor()

class Window(QMainWindow):
    def __init__(self):
        super(Window, self).__init__()

        self.setWindowIcon(QtGui.QIcon("./lib/icons/book.ico"))
        ui_window = loadUi("./lib/window/window.ui", self)

#--------------------------------------------------------------->

        def kayit_listele():
            kayit_listesi = ui_window.kayit_listesi
            kayit_listesi.clear()

            kayit_listesi.setHorizontalHeaderLabels(("ID", "Ad - Soyad", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

            kayit_listesi.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)
            db_cursor.execute("SELECT * FROM kutuphane")

            for indexSatir, kayitNumarasi in enumerate(db_cursor):
                for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                    kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

        kayit_listele()

#--------------------------------------------------------------->

        def kitap_listele():
            kitap_listesi = ui_window.kitap_listesi
            kitap_listesi.clear()
            kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))
            kitap_listesi.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)

            db_cursor.execute("SELECT * FROM kitaplar")

            for indexSatir, kayitNumarasi in enumerate(db_cursor):
                for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                    kitap_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

        kitap_listele()

#--------------------------------------------------------------->

        def kayit_ara_penceresi():
            self.kayit_ara_pencere = QMainWindow()
            self.kayit_ara_pencere.setWindowIcon(QtGui.QIcon("./lib/icons/book.ico"))
            ui_kayit_ara = loadUi("./lib/pop-window/kayit_ara.ui", self.kayit_ara_pencere)

            kayit_listesi = ui_kayit_ara.kayit_listesi
            kayit_listesi.clear()
            kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))
            kayit_listesi.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)

            #------------------------------------------->

            def id_ara_backend(aranacak_id: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE id LIKE "{aranacak_id}"'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def id_ara():
                aranacak_id = str(ui_kayit_ara.sorgu_lineEdit.text())
                id_ara_backend(aranacak_id=aranacak_id)

            KayitIDAraButonu = ui_kayit_ara.btnIDAra
            KayitIDAraButonu.clicked.connect(id_ara)

            #------------------------------------------->

            def isim_ara_backend(aranacak_isim: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE isim_soyisim LIKE "{aranacak_isim}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def isim_ara():
                aranacak_isim = str(ui_kayit_ara.sorgu_lineEdit.text())
                isim_ara_backend(aranacak_isim=aranacak_isim)

            KayitIsimAraButonu = ui_kayit_ara.btnIsimAra
            KayitIsimAraButonu.clicked.connect(isim_ara)

            #------------------------------------------->

            def sinif_ara_backend(aranacak_sinif: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE sinif LIKE "{aranacak_sinif}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))


                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def sinif_ara():
                aranacak_sinif = str(ui_kayit_ara.sorgu_lineEdit.text())
                sinif_ara_backend(aranacak_sinif=aranacak_sinif)

            KayitSinifAraButonu = ui_kayit_ara.btnSinifAra
            KayitSinifAraButonu.clicked.connect(sinif_ara)

            #------------------------------------------->

            def numara_ara_backend(aranacak_numara: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE numara LIKE "{aranacak_numara}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def numara_ara():
                aranacak_numara = str(ui_kayit_ara.sorgu_lineEdit.text())
                numara_ara_backend(aranacak_numara=aranacak_numara)

            KayitNumaraAraButonu = ui_kayit_ara.btnNumaraAra
            KayitNumaraAraButonu.clicked.connect(numara_ara)

            #------------------------------------------->

            def kitap_ismi_ara_backend(aranacak_kitap_ismi: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE kitap_ismi LIKE "{aranacak_kitap_ismi}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitap_ismi_ara():
                aranacak_kitap_ismi = str(ui_kayit_ara.sorgu_lineEdit.text())
                kitap_ismi_ara_backend(aranacak_kitap_ismi=aranacak_kitap_ismi)

            KayitKitapIsmiAraButonu = ui_kayit_ara.btnKitapIsmiAra
            KayitKitapIsmiAraButonu.clicked.connect(kitap_ismi_ara)

            #------------------------------------------->

            def kitap_yazari_ara_backend(aranacak_kitap_yazari: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE kitap_yazari LIKE "{aranacak_kitap_yazari}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitap_yazari_ara():
                aranacak_kitap_yazari = str(ui_kayit_ara.sorgu_lineEdit.text())
                kitap_yazari_ara_backend(aranacak_kitap_yazari=aranacak_kitap_yazari)

            KayitKitapYazariAraButonu = ui_kayit_ara.btnKitapYazariAra
            KayitKitapYazariAraButonu.clicked.connect(kitap_yazari_ara)

            #------------------------------------------->

            def kitaplik_ara_backend(aranacak_kitaplik: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE kitaplik LIKE "{aranacak_kitaplik}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitaplik_ara():
                aranacak_kitaplik = str(ui_kayit_ara.sorgu_lineEdit.text())
                kitaplik_ara_backend(aranacak_kitaplik=aranacak_kitaplik)

            KayitKitaplikAraButonu = ui_kayit_ara.btnKitaplikAra
            KayitKitaplikAraButonu.clicked.connect(kitaplik_ara)

            #------------------------------------------->

            def teslim_durumu_ara_backend(aranacak_durum: str):
                sorgu = f'''SELECT * FROM kutuphane WHERE teslim_durumu LIKE "{aranacak_durum}%" ORDER BY kitap_son_teslim_tarihi ASC'''
                db_cursor.execute(sorgu)

                kayit_listesi.clear()
                kayit_listesi.setHorizontalHeaderLabels(("ID", "İsim - Soyisim", "Sınıf", "Numara", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı", "Kitap Alınma Tarihi", "Kitap Son Teslim Tarihi", "Teslim Durumu"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kayit_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def teslim_durumu_ara():
                aranacak_durum = str(ui_kayit_ara.sorgu_lineEdit.text())
                teslim_durumu_ara_backend(aranacak_durum=aranacak_durum)

            KayitTeslimDurumuAraButonu = ui_kayit_ara.btnTeslimDurumuAra
            KayitTeslimDurumuAraButonu.clicked.connect(teslim_durumu_ara)

            #------------------------------------------->

            self.kayit_ara_pencere.show()

        KayitAraButonu = ui_window.btnKayitAra
        KayitAraButonu.clicked.connect(kayit_ara_penceresi)

#--------------------------------------------------------------->

        def kayit_ekle_penceresi():
            self.kayit_ekle_pencere = QMainWindow()
            self.kayit_ekle_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kayit_ekle = loadUi("./lib/pop-window/kayit_ekle.ui", self.kayit_ekle_pencere)

            def kayit_ekle():
                id = str(ui_kayit_ekle.id_lineEdit.text())
                isim_soyisim = ui_kayit_ekle.isim_soyisim_lineEdit.text()
                sinif = ui_kayit_ekle.sinif_comboBox.currentText()
                numara = ui_kayit_ekle.numara_lineEdit.text()
                kitap_ismi = ui_kayit_ekle.kitap_ismi_lineEdit.text()
                kitap_yazari = ui_kayit_ekle.kitap_yazari_lineEdit.text()
                kitaplik = ui_kayit_ekle.kitaplik_comboBox.currentText()
                kitap_rafi = ui_kayit_ekle.kitap_rafi_comboBox.currentText()
                kitap_alinma_tarihi = zaman.simdiki_zaman()
                kitap_son_teslim_tarihi = ui_kayit_ekle.kitap_son_teslim_tarihi_lineEdit.text()

                kutuphane.kayit_ekle(id=id, isim_soyisim=isim_soyisim, sinif=sinif, numara=numara, kitap_ismi=kitap_ismi, kitap_yazari=kitap_yazari, kitaplik=kitaplik, kitap_rafi=kitap_rafi, kitap_alinma_tarihi=kitap_alinma_tarihi, kitap_son_teslim_tarihi=kitap_son_teslim_tarihi, teslim_durumu="Etmedi")

                ui_kayit_ekle.id_lineEdit.clear()
                ui_kayit_ekle.isim_soyisim_lineEdit.clear()
                ui_kayit_ekle.numara_lineEdit.clear()
                ui_kayit_ekle.kitap_ismi_lineEdit.clear()
                ui_kayit_ekle.kitap_yazari_lineEdit.clear()
                ui_kayit_ekle.kitap_son_teslim_tarihi_lineEdit.clear()
                ui_kayit_ekle.sinif_comboBox.setCurrentIndex(0)
                ui_kayit_ekle.kitaplik_comboBox.setCurrentIndex(0)
                ui_kayit_ekle.kitap_rafi_comboBox.setCurrentIndex(0)
                kayit_listele()

            KayitEkleButonu = ui_kayit_ekle.btnKayitEkle
            KayitEkleButonu.clicked.connect(kayit_ekle)

            self.kayit_ekle_pencere.show()
        
        KayitEkleButonu = ui_window.btnKayitEkle
        KayitEkleButonu.clicked.connect(kayit_ekle_penceresi)

#--------------------------------------------------------------->

        def kayit_guncelle_penceresi():
            self.kayit_guncelle_pencere = QMainWindow()
            self.kayit_guncelle_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kayit_guncelle = loadUi("./lib/pop-window/kayit_guncelle.ui", self.kayit_guncelle_pencere)
            
            def id_guncelle():
                eski_id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_id = str(ui_kayit_guncelle.yeni_id_lineEdit.text())
                kutuphane.id_guncelle(eski_id=eski_id, yeni_id=yeni_id)

                ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.clear()
                ui_kayit_guncelle.yeni_id_lineEdit.clear()
                kayit_listele()

            IdGuncelleButonu = ui_kayit_guncelle.btnIdGuncelle
            IdGuncelleButonu.clicked.connect(id_guncelle)

            def isim_soyisim_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_isim_soyisim = str(ui_kayit_guncelle.yeni_isim_soyisim_lineEdit.text())
                kutuphane.isim_soyisim_guncelle(id=id, yeni_isim_soyisim=yeni_isim_soyisim)

                ui_kayit_guncelle.yeni_isim_soyisim_lineEdit.clear()
                kayit_listele()

            IsimSoyisimGuncelleButonu = ui_kayit_guncelle.btnIsimGuncelle
            IsimSoyisimGuncelleButonu.clicked.connect(isim_soyisim_guncelle)

            def sinif_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_sinif = str(ui_kayit_guncelle.yeni_sinif_comboBox.currentText())
                kutuphane.sinif_guncelle(id=id, yeni_sinif=yeni_sinif)

                ui_kayit_guncelle.yeni_sinif_comboBox.setCurrentIndex(0)
                kayit_listele()

            SinifGuncelleButonu = ui_kayit_guncelle.btnSinifGuncelle
            SinifGuncelleButonu.clicked.connect(sinif_guncelle)

            def numara_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_numara = str(ui_kayit_guncelle.yeni_numara_lineEdit.text())
                kutuphane.numara_guncelle(id=id, yeni_numara=yeni_numara)

                ui_kayit_guncelle.yeni_numara_lineEdit.clear()
                kayit_listele()

            NumaraGuncelleButonu = ui_kayit_guncelle.btnNumaraGuncelle
            NumaraGuncelleButonu.clicked.connect(numara_guncelle)

            def kitap_ismi_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_kitap_ismi = str(ui_kayit_guncelle.yeni_kitap_ismi_lineEdit.text())
                kutuphane.kitap_ismi_guncelle(id=id, yeni_kitap_ismi=yeni_kitap_ismi)

                ui_kayit_guncelle.yeni_kitap_ismi_lineEdit.clear()
                kayit_listele()

            KitapIsmiGuncelleButonu = ui_kayit_guncelle.btnKitapIsmiGuncelle
            KitapIsmiGuncelleButonu.clicked.connect(kitap_ismi_guncelle)

            def kitap_yazari_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_kitap_yazari = str(ui_kayit_guncelle.yeni_kitap_yazari_lineEdit.text())
                kutuphane.kitap_yazari_guncelle(id=id, yeni_kitap_yazari=yeni_kitap_yazari)

                ui_kayit_guncelle.yeni_kitap_yazari_lineEdit.clear()
                kayit_listele()

            KitapYazariGuncelleButonu = ui_kayit_guncelle.btnKitapYazariGuncelle
            KitapYazariGuncelleButonu.clicked.connect(kitap_yazari_guncelle)

            def kitaplik_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_kitaplik = str(ui_kayit_guncelle.yeni_kitaplik_comboBox.currentText())
                kutuphane.kitaplik_guncelle(id=id, yeni_kitaplik=yeni_kitaplik)

                ui_kayit_guncelle.yeni_kitaplik_comboBox.setCurrentIndex(0)
                kayit_listele()

            KitaplikGuncelleButonu = ui_kayit_guncelle.btnKitaplikGuncelle
            KitaplikGuncelleButonu.clicked.connect(kitaplik_guncelle)

            def kitap_rafi_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_kitap_rafi = str(ui_kayit_guncelle.yeni_kitap_rafi_comboBox.currentText())
                kutuphane.kitap_rafi_guncelle(id=id, yeni_kitap_rafi=yeni_kitap_rafi)

                ui_kayit_guncelle.yeni_kitap_rafi_comboBox.setCurrentIndex(0)
                kayit_listele()

            KitapRafiGuncelleButonu = ui_kayit_guncelle.btnKitapRafiGuncelle
            KitapRafiGuncelleButonu.clicked.connect(kitap_rafi_guncelle)

            def kitap_son_teslim_tarihi_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_kitap_son_teslim_tarihi = str(ui_kayit_guncelle.yeni_kitap_son_teslim_tarihi_lineEdit.text())
                kutuphane.kitap_son_teslim_tarihi_guncelle(id=id, yeni_kitap_son_teslim_tarihi=yeni_kitap_son_teslim_tarihi)

                ui_kayit_guncelle.yeni_kitap_son_teslim_tarihi_lineEdit.clear()
                kayit_listele()

            KitapSonTeslimTarihiGuncelleButonu = ui_kayit_guncelle.btnKitapSonTeslimTarihiGuncelle
            KitapSonTeslimTarihiGuncelleButonu.clicked.connect(kitap_son_teslim_tarihi_guncelle)

            def teslim_durumu_guncelle():
                id = str(ui_kayit_guncelle.degistirilecek_kaydin_id_bilgisi_lineEdit.text())
                yeni_teslim_durumu = str(ui_kayit_guncelle.yeni_teslim_durumu_comboBox.currentText())
                kutuphane.teslim_durumu_guncelle(id=id, yeni_teslim_durumu=yeni_teslim_durumu)

                ui_kayit_guncelle.yeni_teslim_durumu_comboBox.setCurrentIndex(0)
                kayit_listele()

            KitapTeslimDurumunuGuncelleButonu = ui_kayit_guncelle.btnKitapTeslimDurumuGuncelle
            KitapTeslimDurumunuGuncelleButonu.clicked.connect(teslim_durumu_guncelle)

            self.kayit_guncelle_pencere.show()

        KayitGuncelleButonu = ui_window.btnKayitGuncelle
        KayitGuncelleButonu.clicked.connect(kayit_guncelle_penceresi)

#--------------------------------------------------------------->

        def kayit_sil_penceresi():
            self.kayit_sil_pencere = QMainWindow()
            self.kayit_sil_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kayit_sil = loadUi("./lib/pop-window/kayit_sil.ui", self.kayit_sil_pencere)

            def kayit_sil():
                id = str(ui_kayit_sil.silinecek_id_lineEdit.text())
                kutuphane.kayit_sil(id=id)

                ui_kayit_sil.silinecek_id_lineEdit.clear()
                kayit_listele()

            KayitSilButonu = ui_kayit_sil.btnKayitSil
            KayitSilButonu.clicked.connect(kayit_sil)

            self.kayit_sil_pencere.show()

        KayitSilButonu = ui_window.btnKayitSil
        KayitSilButonu.clicked.connect(kayit_sil_penceresi)

#--------------------------------------------------------------->

        def kitap_ara_penceresi():
            self.kitap_ara_pencere = QMainWindow()
            self.kitap_ara_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kitap_ara = loadUi("./lib/pop-window/kitap_ara.ui", self.kitap_ara_pencere)
            
            kitap_listesi = ui_kitap_ara.kitap_listesi
            kitap_listesi.clear()
            kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))
            kitap_listesi.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)

            #------------------------------------------->

            def kitap_id_ara_backend(aranacak_id: str):
                sorgu = f'''SELECT * FROM kitaplar WHERE id LIKE "{aranacak_id}"'''
                db_cursor.execute(sorgu)

                kitap_listesi.clear()
                kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kitap_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitap_id_ara():
                aranacak_id = str(ui_kitap_ara.sorgu_lineEdit.text())
                kitap_id_ara_backend(aranacak_id=aranacak_id)

            KitapIDAraButonu = ui_kitap_ara.btnKitapIDAra
            KitapIDAraButonu.clicked.connect(kitap_id_ara)

            #------------------------------------------->

            def kitap_ara_backend(aranacak_kitap: str):
                sorgu = f'''SELECT * FROM kitaplar WHERE kitap_ismi LIKE "{aranacak_kitap}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kitap_listesi.clear()
                kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))
 
                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kitap_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitap_ara():
                aranacak_kitap = str(ui_kitap_ara.sorgu_lineEdit.text())
                kitap_ara_backend(aranacak_kitap=aranacak_kitap)

            KitapAraButonu = ui_kitap_ara.btnKitapAra
            KitapAraButonu.clicked.connect(kitap_ara)

            #------------------------------------------->

            def yazar_ara_backend(aranacak_yazar: str):
                sorgu = f'''SELECT * FROM kitaplar WHERE kitap_yazari LIKE "{aranacak_yazar}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kitap_listesi.clear()
                kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kitap_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def yazar_ara():
                aranacak_yazar = str(ui_kitap_ara.sorgu_lineEdit.text())
                yazar_ara_backend(aranacak_yazar=aranacak_yazar)

            YazarAraButonu = ui_kitap_ara.btnYazarAra
            YazarAraButonu.clicked.connect(yazar_ara)

            #------------------------------------------->

            def kitaplik_ara_backend(aranacak_kitaplik: str):
                sorgu = f'''SELECT * FROM kitaplar WHERE kitaplik LIKE "{aranacak_kitaplik}%" ORDER BY kitaplik ASC, kitap_rafi ASC'''
                db_cursor.execute(sorgu)

                kitap_listesi.clear()
                kitap_listesi.setHorizontalHeaderLabels(("ID", "Kitap İsmi", "Kitap Yazarı", "Kitaplık", "Kitap Rafı"))

                for indexSatir, kayitNumarasi in enumerate(db_cursor):
                    for indexSutun, kayitSutun in enumerate(kayitNumarasi):
                        kitap_listesi.setItem(indexSatir, indexSutun, QTableWidgetItem(str(kayitSutun)))

            def kitaplik_ara():
                aranacak_kitaplik = str(ui_kitap_ara.sorgu_lineEdit.text())
                kitaplik_ara_backend(aranacak_kitaplik=aranacak_kitaplik)

            KitaplikAraButonu = ui_kitap_ara.btnKitaplikAra
            KitaplikAraButonu.clicked.connect(kitaplik_ara)

            self.kitap_ara_pencere.show()

        KitaplardaAraButonu = ui_window.btnKitapAra
        KitaplardaAraButonu.clicked.connect(kitap_ara_penceresi)

#--------------------------------------------------------------->

        def kitap_ekle_penceresi():
            self.kitap_ekle_pencere = QMainWindow()
            self.kitap_ekle_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kitap_ekle = loadUi("./lib/pop-window/kitap_ekle.ui", self.kitap_ekle_pencere)

            def kitap_ekle():
                id = str(ui_kitap_ekle.id_lineEdit.text())
                kitap_ismi = str(ui_kitap_ekle.kitap_ismi_lineEdit.text())
                kitap_yazari = str(ui_kitap_ekle.kitap_yazari_lineEdit.text())
                kitaplik = str(ui_kitap_ekle.kitaplik_comboBox.currentText())
                kitap_rafi = str(ui_kitap_ekle.kitap_rafi_comboBox.currentText())
                kitap.kitap_ekle(id=id, kitap_ismi=kitap_ismi, kitap_yazari=kitap_yazari, kitaplik=kitaplik, kitap_rafi=kitap_rafi)

                ui_kitap_ekle.id_lineEdit.clear()
                ui_kitap_ekle.kitap_ismi_lineEdit.clear()
                ui_kitap_ekle.kitap_yazari_lineEdit.clear()
                ui_kitap_ekle.kitaplik_comboBox.setCurrentIndex(0)
                ui_kitap_ekle.kitap_rafi_comboBox.setCurrentIndex(0)

                kitap_listele()

            KitapEkleButonu = ui_kitap_ekle.btnKitapEkle
            KitapEkleButonu.clicked.connect(kitap_ekle)

            self.kitap_ekle_pencere.show()

        KitapEkleButonu = ui_window.btnKitapEkle
        KitapEkleButonu.clicked.connect(kitap_ekle_penceresi)

#--------------------------------------------------------------->

        def kitap_guncelle_penceresi():
            self.kitap_guncelle_pencere = QMainWindow()
            self.kitap_guncelle_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kitap_guncelle = loadUi("./lib/pop-window/kitap_guncelle.ui", self.kitap_guncelle_pencere)

            def guncelle_kitap_id():
                eski_id = str(ui_kitap_guncelle.degistirilecek_id_lineEdit.text())
                yeni_id = str(ui_kitap_guncelle.yeni_id_lineEdit.text())
                kitap.kitap_id_guncelle(eski_id=eski_id, yeni_id=yeni_id)

                ui_kitap_guncelle.degistirilecek_id_lineEdit.clear()
                ui_kitap_guncelle.yeni_id_lineEdit.clear()
                kitap_listele()

            KitapIdGuncelleButonu = ui_kitap_guncelle.btnIdGuncelle
            KitapIdGuncelleButonu.clicked.connect(guncelle_kitap_id)

            def guncelle_kitap_adi():
                id = str(ui_kitap_guncelle.degistirilecek_id_lineEdit.text())
                yeni_kitap_ismi = str(ui_kitap_guncelle.yeni_kitap_ismi_lineEdit.text())
                kitap.kitap_ismi_guncelle(id=id, yeni_kitap_ismi=yeni_kitap_ismi)

                ui_kitap_guncelle.yeni_kitap_ismi_lineEdit.clear()
                kitap_listele()

            KitapIsmiGuncelleButonu = ui_kitap_guncelle.btnKitapIsmiGuncelle
            KitapIsmiGuncelleButonu.clicked.connect(guncelle_kitap_adi)

            def guncelle_kitap_yazari():
                id = str(ui_kitap_guncelle.degistirilecek_id_lineEdit.text())
                yeni_kitap_yazari = str(ui_kitap_guncelle.yeni_kitap_yazari_lineEdit.text())
                kitap.kitap_yazari_guncelle(id=id, yeni_kitap_yazari=yeni_kitap_yazari)

                ui_kitap_guncelle.yeni_kitap_yazari_lineEdit.clear()
                kitap_listele()

            KitapYazariGuncelleButonu = ui_kitap_guncelle.btnKitapYazariGuncelle
            KitapYazariGuncelleButonu.clicked.connect(guncelle_kitap_yazari)

            def guncelle_kitaplik():
                id = str(ui_kitap_guncelle.degistirilecek_id_lineEdit.text())
                yeni_kitaplik = str(ui_kitap_guncelle.yeni_kitaplik_comboBox.currentText())
                kitap.kitaplik_guncelle(id=id, yeni_kitaplik=yeni_kitaplik)

                ui_kitap_guncelle.yeni_kitaplik_comboBox.setCurrentIndex(0)
                kitap_listele()

            KitaplikGuncelleButonu = ui_kitap_guncelle.btnKitaplikGuncelle
            KitaplikGuncelleButonu.clicked.connect(guncelle_kitaplik)

            def guncelle_kitap_rafi():
                id = str(ui_kitap_guncelle.degistirilecek_id_lineEdit.text())
                yeni_kitap_rafi = str(ui_kitap_guncelle.yeni_kitap_rafi_comboBox.currentText())
                kitap.kitap_rafi_guncelle(id=id, yeni_kitap_rafi=yeni_kitap_rafi)

                ui_kitap_guncelle.yeni_kitap_rafi_comboBox.setCurrentIndex(0)
                kitap_listele()

            KitapRafiGuncelleButonu = ui_kitap_guncelle.btnKitapRafiGuncelle
            KitapRafiGuncelleButonu.clicked.connect(guncelle_kitap_rafi)

            self.kitap_guncelle_pencere.show()

        KitapGuncelleButonu = ui_window.btnKitapGuncelle
        KitapGuncelleButonu.clicked.connect(kitap_guncelle_penceresi)

#--------------------------------------------------------------->

        def kitap_sil_penceresi():
            self.kitap_sil_pencere = QMainWindow()
            self.kitap_sil_pencere.setWindowIcon(QtGui.QIcon('./lib/icons/book.ico'))
            ui_kitap_sil = loadUi("./lib/pop-window/kitap_sil.ui", self.kitap_sil_pencere)

            def kitap_sil():
                id = str(ui_kitap_sil.silinecek_id_lineEdit.text())
                kitap.kitap_sil(id=id)

                ui_kitap_sil.silinecek_id_lineEdit.clear()

                kitap_listele()

            KitapSilButonu = ui_kitap_sil.btnKitapSil
            KitapSilButonu.clicked.connect(kitap_sil)

            self.kitap_sil_pencere.show()

        KitapSilButonu = ui_window.btnKitapSil
        KitapSilButonu.clicked.connect(kitap_sil_penceresi)

#--------------------------------------------------------------->

        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = Window()
    app.exec_()

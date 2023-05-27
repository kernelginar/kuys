#!/usr/bin/env python3
from os.path import dirname
from os import chdir
chdir(f"{dirname(__file__)}/../")

import sqlite3 as sql
db = sql.connect("./database/kutuphane.db")
db_cursor = db.cursor()

#--------------------------------------------------------------->

# Veri tabanı için tablo oluşturma komutu
# db_cursor.execute(f"CREATE TABLE kitaplar (id TEXT PRIMARY KEY, isim_soyisim TEXT, sinif TEXT, numara TEXT, kitap_ismi TEXT, kitap_yazari TEXT, kitaplik TEXT, kitap_rafi TEXT, kitap_alinma_tarihi TEXT, kitap_son_teslim_tarihi TEXT, teslim_durumu TEXT)")
# db.commit()

#--------------------------------------------------------------->

def kayit_ekle(id: str, isim_soyisim: str, sinif: str, numara: str, kitap_ismi: str, kitap_yazari: str, kitaplik: str, kitap_rafi: str, kitap_alinma_tarihi: str, kitap_son_teslim_tarihi: str, teslim_durumu: str):
    db_cursor.execute(f'''INSERT INTO kutuphane
                      (id, isim_soyisim, sinif, numara, kitap_ismi, kitap_yazari, kitaplik, kitap_rafi, kitap_alinma_tarihi, kitap_son_teslim_tarihi, teslim_durumu)
                      VALUES ({id}, "{isim_soyisim}", "{sinif}", "{numara}", "{kitap_ismi}", "{kitap_yazari}", "{kitaplik}", "{kitap_rafi}", "{kitap_alinma_tarihi}", "{kitap_son_teslim_tarihi}", "{teslim_durumu}")''')
    db.commit()

#--------------------------------------------------------------->

def kayit_sil(id: str):
    db_cursor.execute(f'''DELETE FROM kutuphane
                          WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def id_guncelle(eski_id: str, yeni_id: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET id = "{yeni_id}"
                      WHERE id = "{eski_id}"''')
    db.commit()

#--------------------------------------------------------------->

def isim_soyisim_guncelle(id: str, yeni_isim_soyisim: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET isim_soyisim = "{yeni_isim_soyisim}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def sinif_guncelle(id: str, yeni_sinif: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET sinif = "{yeni_sinif}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def numara_guncelle(id: str, yeni_numara: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET numara = "{yeni_numara}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_ismi_guncelle(id: str, yeni_kitap_ismi: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET kitap_ismi = "{yeni_kitap_ismi}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_yazari_guncelle(id: str, yeni_kitap_yazari: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET kitap_yazari = "{yeni_kitap_yazari}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitaplik_guncelle(id: str, yeni_kitaplik: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET kitaplik = "{yeni_kitaplik}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_rafi_guncelle(id: str, yeni_kitap_rafi: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET kitap_rafi = "{yeni_kitap_rafi}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_son_teslim_tarihi_guncelle(id: str, yeni_kitap_son_teslim_tarihi: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET kitap_son_teslim_tarihi = "{yeni_kitap_son_teslim_tarihi}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def teslim_durumu_guncelle(id: str, yeni_teslim_durumu: str):
    db_cursor.execute(f'''UPDATE kutuphane
                      SET teslim_durumu = "{yeni_teslim_durumu}"
                      WHERE id = "{id}"''')
    db.commit()

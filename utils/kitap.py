#!/usr/bin/env python3
from os.path import dirname
from os import chdir
chdir(f"{dirname(__file__)}/../")

import sqlite3 as sql
db = sql.connect("./database/kutuphane.db")
db_cursor = db.cursor()

#--------------------------------------------------------------->

def kitap_ekle(id: str, kitap_ismi: str, kitap_yazari: str, kitaplik: str, kitap_rafi: str):
    db_cursor.execute(f'''INSERT INTO kitaplar
                      (id, kitap_ismi, kitap_yazari, kitaplik, kitap_rafi)
                      VALUES ("{id}", "{kitap_ismi}", "{kitap_yazari}", "{kitaplik}", "{kitap_rafi}")''')
    db.commit()

#--------------------------------------------------------------->

def kitap_sil(id: str):
    db_cursor.execute(f'''DELETE FROM kitaplar
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_id_guncelle(eski_id: str, yeni_id: str):
    db_cursor.execute(f'''UPDATE kitaplar
                      SET id = "{yeni_id}"
                      WHERE id = "{eski_id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_ismi_guncelle(id: str, yeni_kitap_ismi: str):
    db_cursor.execute(f'''UPDATE kitaplar
                      SET kitap_ismi = "{yeni_kitap_ismi}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_yazari_guncelle(id: str, yeni_kitap_yazari: str):
    db_cursor.execute(f'''UPDATE kitaplar
                      SET kitap_yazari = "{yeni_kitap_yazari}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitaplik_guncelle(id: str, yeni_kitaplik: str):
    db_cursor.execute(f'''UPDATE kitaplar
                      SET kitaplik = "{yeni_kitaplik}"
                      WHERE id = "{id}"''')
    db.commit()

#--------------------------------------------------------------->

def kitap_rafi_guncelle(id: str, yeni_kitap_rafi: str):
    db_cursor.execute(f'''UPDATE kitaplar
                      SET kitap_rafi = "{yeni_kitap_rafi}"
                      WHERE id = "{id}"''')
    db.commit()

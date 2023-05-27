#!/usr/bin/env python3
import sqlite3 as sql
db = sql.connect("./kutuphane.db")
db_cursor = db.cursor()

db_cursor.execute(f"CREATE TABLE kutuphane (id TEXT PRIMARY KEY, isim_soyisim TEXT, sinif TEXT, numara TEXT, kitap_ismi TEXT, kitap_yazari TEXT, kitaplik TEXT, kitap_rafi TEXT, kitap_alinma_tarihi TEXT, kitap_son_teslim_tarihi TEXT, teslim_durumu TEXT)")
db.commit()

db_cursor.execute(f"CREATE TABLE kitaplar (id TEXT PRIMAY KEY, kitap_ismi TEXT, kitap_yazari TEXT, kitaplik TEXT, kitap_rafi TEXT)")
db.commit()

db.close()

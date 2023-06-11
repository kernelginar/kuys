# Kütüphane Yönetim Sistemi
Bu program, Python, SQLite3 ve PyQt5 kullanılarak yazıldı. <br />
Temel bütün işlevler programda yer alıyor. Mesela:

- Kayıt Listesi
    - Kayıt Listesi içinde arama yapmak
- Kayıt Eklemek
- Kayıt Güncellemek
- Kayıt Silmek

- Kitap Listesi
    - Kitap Listesi içinde arama yapmak
- Kitap Eklemek
- Kitap Güncellemek
- Kitap Silmek

## Bağımlılıklar
Bu programın çalışabilmesi için belli bağımlılıkların yüklenmesi gerekir. Bu bağımlılıklar şunlardır:

- Python3
    - PyQt5

Python yükledikten sonra `PyQt5` bağımlılığını şu şekilde yükleyebilirsiniz:

###### Windows
```bash
python -m pip install pyqt5
```

###### Arch Linux tabanlı dağıtımlar
```bash
sudo pacman -S python-pyqt5
```

###### Debian GNU/Linux tabanlı dağıtımlar
```bash
sudo apt install python3-pyqt5
```

###### Diğer Linux dağıtımları
```bash
python3 -m pip install -r requirements.txt
```

---

## Program nasıl kullanılır?
Bağımlılığın kurulumu yapıldıktan sonra, program şu şekilde açılır:
```bash
python3 library.py
```

---

## Projeyi "Çalıştırılabilir" dosya hâline getirmek
Programı, kullandığınız işletim sisteminin "Çalıştırılabilir" dosya formatına çevirmek istiyorsanız Python'un `nuitka` isimli modülünü kullanabilirsiniz.

Yüklemek için:
```bash
python -m pip install nuitka
```

Ardından derleme işlemi şu şekilde yapılır:

###### Windows
```bash
nuitka --follow-imports --disable-console --windows-icon-from-ico=".\lib\icons\book.ico"
```

###### Linux
```bash
python3 -m nuitka --follow-imports --disable-console --linux-icon="./lib/icons/book.ico"
```

Bu noktada işlemlerin tamamlanmasını bekleyin. Windows kullanıcıları bu işlemi yaparken iki tane indirme işlemi gerçekleştirecek. <br />
İlki `gcc` indirmek, ikincisi `ccache` indirmek. `nuitka` modülü bunu otomatik olarak yapıyor. Daha fazla bilgi için araştırma yapabilirsiniz.

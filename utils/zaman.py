#!/usr/bin/env python3
from datetime import datetime

def simdiki_zaman():
    x = datetime.now()
    return datetime.strftime(x, "%d/%m/%Y-%H:%M:%S")

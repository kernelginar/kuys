#!/usr/bin/env python3
from datetime import datetime

def simdiki_zaman():
    x = datetime.now()
    return datetime.strftime(x, "%Y/%m/%d - %H:%M")

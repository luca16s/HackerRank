#!/bin/python3

import math
import os
import random
import re
import sys

n = 20
isOdd: int = n % 2

if not isOdd == 0 or n == 1:
    print('Weird')
elif isOdd == 0 and 2 <= n <= 5:
    print('Not Weird')
elif isOdd == 0 and 6 <= n <= 20:
    print('Weird')
elif isOdd == 0 and n > 20:
    print('Not Weird')

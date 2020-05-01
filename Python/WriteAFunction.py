def is_leap(year: int):
    leap: bool = False
    if year % 4 == 0:
        if year % 100 == 0 and not year % 400 == 0:
            leap = False
        else:
            leap = True
    return leap


year: int = int(input())
print(is_leap(year))

import string


def printNumber(number: int):
    text: string = ''
    for i in range(0, number):
        text += f'{i + 1}'
    print(text)


n = 3  # int(input())
printNumber(n)

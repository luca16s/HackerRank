"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Let's learn about list comprehensions! You are given three     """
""" integers X,Y and Z representing the dimensions of a cuboid     """
""" along with an integer N. You have to print a list of all       """
""" possible coordinates given by (i,j,k) on a 3D grid where the   """
""" sum of i+j+k is not equal to N.                                """
""" Here, 0 <= i <= X; 0 <= j <=Y; 0 <= k <= Z                     """
"""----------------------------------------------------------------"""

def calcula_possibilidades(eixo_x: int, eixo_y: int, eixo_z: int):
    return ((eixo_x + eixo_y + eixo_z) * 3) - 1


def calcula_total_lista(lista_preenchida):
    total_lista: int = 0
    for numero in lista_preenchida:
        total_lista += numero
    return total_lista


x: int = 1  # int(input())
y: int = 1  # int(input())
z: int = 1  # int(input())
n: int = 2  # int(input())

possibilidades: int = calcula_possibilidades(x, y, z)

lista = [[a for a in range(0, 3)], [b for b in range(0, 3)], [c for c in range(0, 3)]]
print(lista)

"""for possibilidade in range(possibilidades):
    lista = [[x for x in range(x + 2)]]"""

"""if not n == calcula_total_lista(lista):
        lista = [i for i in range(3)]
        print(lista)"""



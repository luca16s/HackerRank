"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Given an integer, N, and N space-separated integers as input,  """
""" create a tuple, T, of those N integers. Then compute and print """
""" the result of hash(T).                                         """
"""----------------------------------------------------------------"""

n = int(input())
integer_list = map(int, input().split())
tupla = tuple(integer_list)
print(tupla.__hash__())


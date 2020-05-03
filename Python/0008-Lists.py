"""----------------------------------------------------------------"""
"""------------------------------TASK------------------------------"""
""" Consider a list (list = []). You can perform the following     """
""" commands:                                                      """
""" insert i e: Insert integer e at position i.                    """
""" print: Print the list.                                         """
""" remove e: Delete the first occurrence of integer e.            """
""" append e: Insert integer e at the end of the list.             """
""" sort: Sort the list.                                           """
""" pop: Pop the last element from the list.                       """
""" reverse: Reverse the list.                                     """
""" Initialize your list and read in the value of n followed by n  """
""" lines of commands where each command will be of the 7 types    """
""" listed above. Iterate through each command in order and        """
""" perform the corresponding operation on your list.              """
"""----------------------------------------------------------------"""


lista = []
N = int(input())
for i in range(0, N):
    command = input().rsplit(" ")
    if command[0] == 'insert':
        lista.insert(int(command[1]), int(command[2]))
    elif command[0] == 'print':
        print(lista)
    elif command[0] == 'remove':
        lista.remove(int(command[1]))
    elif command[0] == 'append':
        lista.append(int(command[1]))
    elif command[0] == 'sort':
        lista.sort()
    elif command[0] == 'pop':
        lista.pop()
    elif command[0] == 'reverse':
        lista.reverse()

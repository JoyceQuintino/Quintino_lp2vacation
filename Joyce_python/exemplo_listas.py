
#listas

lista = []
print(len(lista))

lista = [1,2,3,4,7,9,10,100,35,65,27]

print(lista)

cont = 0
while cont < len(lista):
    if lista[cont]%2==0:
        print(lista[cont])
    cont += 1

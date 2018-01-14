
#Condicionais
def degrau(u):
    if u >= 0:
        return 1
    else:
        return 0

print("Simulação da porta E em um Perceptron: ")

x = int(input("Digite o primeiro valor: "))
w = int(input("Digite o segundo valor: "))

limiar = -1
u = x*w+limiar

print(degrau(u))

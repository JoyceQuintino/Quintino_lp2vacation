
nome = input("Digite seu nome: ")
peso = float(input("Digite seu peso: "))
altura = float(input("Digite sua altura: "))

imc = peso/(altura*altura)

if imc >= 18.5 and imc < 25:
    print("IMC: ", imc, " peso normal")
elif imc >= 25 and imc < 30:
    print("IMC: ", imc, " acima do peso")
elif imc >= 30 and imc < 35:
    print("IMC: ", imc, " obesidade 1")
elif imc >= 35 and imc < 40:
    print("IMC: ", imc, " obesidade 2")
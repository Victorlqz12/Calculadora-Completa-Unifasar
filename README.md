# 📌 Calculadora Avançada em C#

## 📖 Descrição
Este projeto implementa uma **calculadora avançada em C#**, que além de realizar operações matemáticas básicas e científicas, também **armazena os resultados em diferentes estruturas de dados**:

- **Fila (Queue)** → segue a ordem FIFO (*First In, First Out*).  
- **Pilha (Stack)** → segue a ordem LIFO (*Last In, First Out*).  
- **Lista (List)** → mantém os resultados na ordem de inserção.

O programa possui um **menu interativo no console**, permitindo realizar novos cálculos, visualizar os resultados acumulados e sair da aplicação.

---

## ⚙️ Funcionalidades

✅ Operações básicas:  
- **Soma (+)**  
- **Subtração (-)**  
- **Multiplicação (*)**  
- **Divisão (/)** (com tratamento de divisão por zero)  
- **Potência (^)**  
- **Módulo (%)**

✅ Operações científicas:  
- **Cosseno (cos)**  
- **Tangente (tan)**  
- **Raiz Quadrada (rq)** (com tratamento para números negativos)

✅ Armazenamento de resultados em:  
- **Fila (FIFO)**  
- **Pilha (LIFO)**  
- **Lista**  

✅ Visualização dos resultados acumulados em cada estrutura.

---

## 🖥️ Como usar

1. Clone este repositório ou copie o código para um arquivo chamado `Program.cs`.  
2. Compile o programa no **.NET SDK** ou utilize uma IDE como **Visual Studio** ou **Rider**.  
3. Execute o programa.  
4. O menu será exibido com as seguintes opções:

   Realizar um novo cálculo

   Imprimir resultados acumulados

   Sair


5. Escolha a operação desejada e siga as instruções do console.

---

## 📂 Estrutura do Código

- `Main()` → Contém o menu principal do programa.  
- `RealizarCalculo()` → Responsável por solicitar a operação, os números e calcular o resultado.  
- `ImprimirResultados()` → Exibe os resultados armazenados em **Fila, Pilha ou Lista**.  

---


---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET (versão compatível: .NET 6.0 ou superior)  
- **Paradigma:** Programação Estruturada e uso de Estruturas de Dados  

---

## 📌 Observações

- Operações inválidas ou entradas incorretas são tratadas com mensagens de erro.  
- É possível visualizar os resultados armazenados em qualquer momento, escolhendo a opção **2** no menu principal.  

---

🔹 Desenvolvido para fins de estudo de **C# e Estruturas de Dados**.







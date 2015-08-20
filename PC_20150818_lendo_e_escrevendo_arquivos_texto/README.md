Lendo e escrevendo arquivos em C# com Orientação a Objetos
==========================================================


Este é um exercício feito para aula de Linguagem Comercial da faculdade CIMATEC.

A proposta do desafio é fazer dois sistemas legados conversarem através da leitura e escrita de arquivos TXT.

O cenário hipotético nos diz que uma determinada empresa A possui dois sistemas legados, Controle de Pedidos e Gerenciamento Financeiro, onde ambos não possuem interface de comunicação externa para troca de informações, porém ambos são capazes de ler e escrever arquivos textos de dados, cada um com seu layout de arquivo próprio.

O desafio é criar um conversor de arquivos que receba o arquivo do Controle de Pedidos, o interprete a partir dele gere um novo arquivo que possa ser lido pelo Gerenciamento financeiro.

O modelo dos layouts destes arquivos estão na pasta "modelos" do repositório.

----------


Como foi feito
--------------

A solução dada foi apoiada no paradigma da Orientação a Objetos utilizando a linguagem C# para gerar um aplicativo de linha de comando (não é windows forms).

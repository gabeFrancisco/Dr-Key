# Doctor Key
![Logo](https://raw.githubusercontent.com/gabeFrancisco/Dr-Key/assets/logo.png)
### Gerenciador de chaves automotivas para Windows.

### Motivação
Criei esse projeto para organizar e gerenciar produtos para um chaveiro automotivo. 
Como a lista de chaves é extensa e complexa de organizar, inclusive com mais pessoas trabalhando no meio, fez necessário a criação deste software.
Esta foi minha primeira experiência com um software real e funcional.

### Tecnologias utilizadas e aprendizado
Como nessa época eu estava estudando C# e tendo contato com WinForms, aproveitei a oportunidade e criei esse projeto. 
A medida que eu arquitetava o software, eu aprendia ao mesmo tempo.
Foi aqui que estudei bastante a respeito de padrões de projeto e banco de dados. Aprendi que um software não é só feito de código e sim de
bastante planejamento e adaptação ao problema real ao qual ele iria resolver. Não adianta criar sem solucionar os problemas do mundo real.

No final, o software foi escrito inteiramente em C#, com banco de dados MySQL local e remoto. 

## Estrutura do programa

1 - Tela inicial:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr1.png?raw=true)

Aqui podemos ver a tela inicial do programa com todos os seus recursos!  Temos uma barra de ferramentas na parte superior, uma barra de informações a esquerda onde mostra os dados da chave selecionada. A direita temos a lista principal contendo todas as chaves cadastradas no sistema para o respectivo usuário cadastrado. Na parte inferior temos uma barra de status, mostrando o número total de chaves cadastradas, bem como o modelo de chave atual selecionado e nome de usuário.

2 - Informações da chave selecionada:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr2.png?raw=true)

Aqui temos toda a informação da chave selecionada, contendo ainda uma foto(se houver), observações e alguns botões de ação como **Cancelar** e **Editar Chave**, bem como **Aumentar** e **Diminuir** quantidade em estoque, representados pelos botões de seta para cima e para baixo.

3 - Nova chave:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr3.png?raw=true)

Adicionamos uma nova chave através dessa janela. Note que podemos ver ela recém adicionada na próxima imagem:

![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr4.png?raw=true)

4 - Tela de clientes:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr5.png?raw=true)

Nessa janela podemos gerenciar todos os clientes referentes ao usuário cadastrado. Podemos ver mais informações a respeito do cliente selecionada na janela abaixo:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr6.png?raw=true)
5 - Tela de serviços:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr7.png?raw=true)

Aqui podemos gerenciar uma variedade de serviços que podem ser prestados pelo usuário, sendo devidamente catalogados e conferidos a qualquer momento.
Veja a tela de inserção de um novo serviço na imagem abaixo:

![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr8.png?raw=true)

6 - Tema e modificações:
![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr9.png?raw=true)

É possível customizar o tema para claro ou escuro, a cor principal de seleção, tamanho da fonte, bem como quais colunas serão mostradas na lista principal de chaves.

![enter image description here](https://github.com/gabeFrancisco/Dr-Key/blob/assets/dr10.png?raw=true)


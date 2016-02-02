Intenção:

Separa a construção de um objeto complexo da sua representação, de modo que o mesmo processo de construção pode criar diferentes representações.

Descrição:

O padrão pode ser aplicado quando o algoritimo para a construção de um objeto deve ser independente das partes que o compõe e de como elas são montadas. O processo de construção deve permitir diferentes representações para o objeto que é construído.

Benefícios:

A aplicação deste padrão traz alguns benefícios, como permitir variar a representação interna de um produto, pois uma interface permite ao construtor ocultar essa representação. O padrão melhora a modularidade pelo encapsulamento da forma como um objeto complexo é construido e representado. Em outras palavras, ele isola o código da construção.

Particioantes:

Builder - especifica uma interface abstrata para a criação de partes de um objeto-produto;
Concrete Builder - constrói e monta partes do produto pela implementação da interface de Builder; define e manté, a representação que cria; fornece uma interface para a recuperação do produto;
Director - contrói um objeto usando a interface de Builder;
Product - representa o objeto complexo em construção;Concrete Builder constrói a representação interna do produto e define o processo pelo qual ele é montado; inclui classes que definem as partes constituintes, inclusive as interfaces para a montagem das partes do resultado final;
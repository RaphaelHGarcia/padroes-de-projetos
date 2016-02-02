Intenção:

Fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.


Descrição:

Nesse padrão, a fábrica(Conhecida como Factory) recebe solicitações por objetos concretos a partir de um cliente. Este padrão pode ser utilizado quando um sistema de software precisa ser independente de como classes concretas (produtos) são criadas, compostas ou representadas. No padrão, uma fábrica fica responsável por encapsular a criação de uma família de produtos. Nesse caso, um cliente precisa conhecer somente as interfaces desses produtos, não a sua implementação, aumentando o encapsulamento e abstração.


Beneficios:

A aplicação deste padrão traz como benefício principal o isolamento de classes concretas. Se for necessário trocar uma família inteira de produtos, esse processo se torna menos impactante nas demais partes do sistema, pois as classes-produto ficam isoladas e não expõem sua implementação a classe clientes, diminuindo o acoplamento.

Participantes:

• Abstract Factory - Declara uma interface para operações que criam objetos-produtos abstratos;
• Concrete Factory - Implementa as operações que criam objetos-produtos concretos;
• Abstract Product - Declara uma interface para um tipo de objeto-produto;
• Concrete Product - Define um objeto-produto a ser criado pela correspondente fábrica concreta; Implementa a interface de Abstract Product;
• Cliente - Usa somente as interfaces declaradas pelas classes Abstract Factory e Abstract Product;
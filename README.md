# MarsRoversZup
Mars Rovers Project for Zup

Uma solução para o projeto Mars Rovers.

- Instruções:

1: Importe o projeto em sua IDE de preferência, ou utilize o executável MarsRovers.exe em /MarsRoversZup/tree/master/MarsRovers/bin/Release
2: Insira as coordenadas do limite superior direito do plateau (Exemplo: 5 8).
3: Um rover será criado com a posição(X Y) e direcionamento (N, W, S ou E) fornecidos neste momento (Exemplo: 1 2 N).
4: Forneça uma linha de comando para o rover, utilizando L para virar à esquerda, R para virar à direita, e M para mover à frente.
5: As coordenadas finais do rover, assim como sua direção final serão apresentados.
6: Repita a partir do passo 3 para criar um novo rover, ou digite "EXIT" para finalizar.

- Validações implementadas:
1: Não é possível dar coordenadas negativas para o limite superior direito do plateau.
2: Não é possível criar um rover fora dos limites do plateau.
3: Linhas de comando para o rover com caracteres em lower case são convertidas automaticamente para upper case (Ex.: MMmmLLr -> MMMMLLR)
4: O mesmo é válido para o comando "EXIT" ou coordenadas

- Exemplos de Entradas
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
0 0 N
MMMMMRMMMMMRMMMMMRMMMMMR

- Saídas esperadas

1 3 N
5 1 E
0 0 N

- Obsvervações:
1: Foi considerado que ao termino da execução da linha de comando de um rover, este se retira do plateau, não havendo colisão entre rovers.
2: Rovers executam suas instruções sequencialmente, ou seja, um rover não inicia sua execução caso outro rover esteja trabalhando.

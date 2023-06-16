# LeapFrog

Crear en Unity un videojuego en 2D llamado LeapFrog. El objetivo del juego es mostrar una rana
saltando aleatoriamente de piedra en piedra para cruzar el río, contabilizando el número de saltos
que hace. (10 puntos).

## El problema de la rana
Una rana va a cruzar un río dando saltos. La rana dispone de 10 puntos (piedras o bloques) a los que
puede saltar indistintamente (el punto en la décima posición es ya la otra orilla), pero elegirá
aleatoriamente a cual saltará, siempre avanzando. Es decir, elegirá al azar entre los puntos de salto
que quedan más adelante de dónde se encuentre en cada momento.

El problema matemático consiste en calcular el número medio de saltos que realizará la rana (es
decir, si la rana cruzase el río un número muy alto de veces, cada una de ellas con un conjunto de
saltos aleatorios y diferentes en cada ocasión, cual sería el número medio de saltos por cada cruce
del río).

## Simulación por ordenador
Pero a nosotros no nos interesa (o no tanto) el problema matemático como el hecho de que se puede
simular por ordenador y, además, se puede convertir en una animación como si fuese un videojuego.

La rana deberá escoger aleatoriamente el punto al que “decide” saltar, y ejecutar el salto que la lleve
al lugar elegido. La rana saltará cuando se pulse la tecla espacio.
Una vez que se alcanzó la orilla opuesta volverá “por teletransporte” al punto de partida, también al
pulsar la barra espaciadora, y a partir de ahí se repetirá el proceso.
Utilizando OnGUI() se deberá mostrar en la parte superior izquierda, el número de ensayo que se
está efectuando en este momento (entendiendo por ensayo cada vez que se cruza el río) y el
números de saltos efectuados en este ensayo.
En la parte superior derecha se mostrará el número total de ensayos completados, el número de
saltos totales en esos ensayos, y la media resultante. Recalco que los datos de la derecha
corresponden a ensayos completados, y, por lo tanto solo se modifican cuando la rana completa el
cruce del río.

## Visualización
Se creará un prefab para los bloques que consistirá en un simple rectángulo de dimensiones 1 x 0.4

Al comienzo del juego se espanearán 10 de estos prefabs para representar los puntos a los que
puede sarltar la rana. Estos prefabs deberán colocarse en la coordenada Y = -2 y horizontalmente
centrados en la pantalla, separados 1.8 metros entre centros de dos consecutivos.

La rana comenzará el juego en la posición de coordenada Y = -1.5 y en la posición X que
correspondería al siguiente bloque hacia la izquierda si hubiese uno más. Cuando efectúe un salto se
moverá a velocidad constante de 5 metros/segundo siguiendo una línea poligonal formada por dos
segmentos rectilíneos. El primer segmento partirá de la posición que ocupe la rana al comienzo del
salto y se extenderá hacia la derecha la mitad de la distancia hasta el punto de destino, y alcanzará
una altura de 2 metros respecto a la del punto de partida. El segundo segmento partirá del punto
final del primero y acabará en el punto definido por la coordenada X de la piedra sobre la que se
aterriza y la misma coordenada Y que tenía la rana antes de iniciar el salto.

Mientras se recorre el primer segmento, la rana debe ejecutar la animación de salto, generada con el
sprite Jump (32x32). Tras alcanzar el punto central y más elevado del salto, la animación será la de
caída, que se genera con sprite Fall (32x32). Antes de iniciar el salto la rana debe ejecutar la
animación de inactividad, generada usando el sprite Idle (32x32), a la que volverá también tras
completarlo.

Mientras la rana esté ejecutando el salto no responderá a la barra espaciadora.

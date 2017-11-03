# Control-de-Enemigos

1) Estructuras y tipos:

Posicion
* x
* y

Enemigo
* id
* nombre
* vida
* posicion

ListaEnemigos
* enemigo
* siguienteEnemigo

	

2) Programar una función que me permita crear e inicializar un enemigo(nodo)
enemigo crear_enemigo(id, nombre, vida, posicion);

Los enemigos tendrán los siguientes datos:
- id = un número irrepetible.
- nombre = "enemigo" + n + 1 
- vida = 100
- posicion=(x = n + 1, y = n + 1)


3) Programar una función que me permita agregar un enemigo a una lista de enemigos
void agregar_enemigo(lista, enemigo);

4) Programar una función que me permita saber cuantos enemigos tengo en una lista.
int numero_enemigos(lista);

5) Programar una función que me permita eliminar un enemigo de la lista indicando su id.
retorno eliminar_enemigo(id);

El valor de retorno 0 = satisfactorio, 1 = hubo algún error

6) Programar una función que me permita eliminar una lista de enemigos.
void eliminar(lista);

7) Programar una función que me permita imprimir por consola los datos de un enemigo indicando su id.
void imprimir_enemigo(id);

8) Programar una función que me permita imprimir por consola los datos de todos los enemigos.
void imprimir_enemigos(lista);

9) Programar una función que me permita buscar y retornar su dirección de nodo de una lista
enemigo buscar_enemigo(lista);

Caso contrario retornará NULL.

10) Programar una función que me permita invertir el orden de los enemigos en una lista
void invertir_lista(lista);

Por ejemplo:
0, 1,2,3,4,5 -> 5, 4, 3, 2, 1, 0

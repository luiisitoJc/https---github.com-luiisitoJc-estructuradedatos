

Console.WriteLine("---------------------------------");
Console.WriteLine("Pilas (Stack) - semana 7");
//Definir una pila
Stack<int> numeros = new Stack<int>(); // la variable número es una pila

//método Push que agrega elementos 
numeros.Push(5);
numeros.Push(10);
numeros.Push(100);
numeros.Push(500);

//imprimir los elementos de la pila
Console.WriteLine(numeros.Pop()); //Elimina el último elemento y lo imprime
Console.WriteLine();
foreach (var item in numeros)
{ Console.WriteLine(item);
}
     



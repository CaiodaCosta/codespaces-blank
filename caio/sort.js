const array1 = [5, 12, 8, 130, 44, 7, 9, 10, 30, 40, ]

function sort(arr) {
  const listaFinal = [...arr];
    for (let i = 0; i < listaFinal.length - 1; i++) {
        for (let j = 0; j < listaFinal.length - 1 - i; j++) {
            
            if (listaFinal[j] > listaFinal[j + 1]) {
                
                let temp = listaFinal[j];
                listaFinal[j] = listaFinal[j + 1];
                listaFinal[j + 1] = temp;
                
                console.log(listaFinal)
                
            }
        }
    }

    return listaFinal;  
}

const resultado = sort(array1);
console.log(resultado);
const array1 = ['spray', 'elite', 'exuberant', 'destruction', 'present']

function filter(arr, elemento) {
    const novaArray = []
    for (let i = 0; i < arr.length; i++) {
        const valor = elemento(arr[i])

        if (valor == true) {

            novaArray.push(arr[i])

        }  //else {return undefined}


    }
    return novaArray

}

const resultado = filter(array1, (arr) => arr.length > 6)
console.log(resultado)
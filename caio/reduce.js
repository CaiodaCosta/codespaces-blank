const array1 = [1, 4, 9, 16]
const array2 = ["Eu", "gosto", "de", "programar"]
const arrayReduce = []
function reduce(acumulador, arr) {
    
    for (let i = 0; i < arr.length; i++) {
       
        if (typeof arr[i] === "string"){
            if (acumulador !== ""){
                
            acumulador += " ";
           
        }
            acumulador += arr[i]
        } else if (typeof arr[i] === "number"){
            if(acumulador == ""){
                acumulador = 0}
            acumulador += arr[i]
                
            }
                
            }

    return acumulador

}

const numero = reduce(arrayReduce, array1)
const string = reduce(arrayReduce, array2)

console.log(numero)
console.log(string)
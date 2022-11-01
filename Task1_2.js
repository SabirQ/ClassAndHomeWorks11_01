var number=101
var counter=0;
if(number<2){
    console.log("Ne sade ne murekkeb.")
}else{
    var result =true;
    for(var i=2; i*i<number; i++){
        counter++
       if(number%i==0){
        console.log("Murekkeb")
        result=false;
        break;
       } 
    }
    if(result){
        console.log("Sadedir")
    }   
    console.log("step counts"+" "+counter)
}
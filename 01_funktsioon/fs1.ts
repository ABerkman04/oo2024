function KMI(kaal:number, pikkus:number){
  return kaal/(pikkus**2);
}

//console.log("Kehamassiindex on: " + KMI(74, 1.73).toFixed(1));
let kehaInfo=KMI(74, 1.73);

function kmiHinnang(index:number):string{
  if(index<16){return "Tervisele ohtik alakaal"}
  if(index<18.5){return "Alakaal";}
  if(index<25){return "Normaalkaal";}
  if(index<30){return "Ülekaal";}
  if(index<35){return "Rasvumine";}
  if(index<40){return "Tugevrasvumine";}
  return "Tervisele ohtik rasvumine";
}
console.log(kmiHinnang(kehaInfo))

let kmiArvud:number[]=[25,18,38,28];
let hinnangud=kmiArvud.map(kmiHinnang);
//console.log(hinnangud);
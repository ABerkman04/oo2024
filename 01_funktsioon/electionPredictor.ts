//Annad ette partei nime ja kui suur tõenäosus on sellel parteil võita 1-10.
function elecPredict(partyName:string, chance:number)
{
  const winChance:number = Math.floor(Math.random() * 10) + 1;
  if(winChance >= chance)
  {
    console.log("Sinu erakond: \"" + partyName + "\" võitis!");
  }
  else
  {
    console.log("Sinu erakond: \"" + partyName + "\" kaotas.");
  }
}

elecPredict("Rikkuse ja Headuse Erakond", 5);
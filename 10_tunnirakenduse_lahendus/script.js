function visualiseeri() {
    var pudeliMaht = document.getElementById("pudeliMaht").value;
    var vedelikuKogus = document.getElementById("vedelikuKogus").value;
    
    
    var pudeliKorgusProtsentides = (vedelikuKogus / pudeliMaht) * 100;
    
    document.getElementById("vedelik").style.height = pudeliKorgusProtsentides + "%";
    document.getElementById("pudeliKorgus").textContent = "Pudeli kõrgus: " + pudeliKorgusProtsentides.toFixed(2) + "%";
  }
  
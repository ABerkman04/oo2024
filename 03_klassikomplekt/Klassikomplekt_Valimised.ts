class Kandidaat {
    nimi: string;
    hääli: number;
    ideoloogia: string;
    värv: string;
    sünniaasta: number;

    constructor(nimi: string, ideoloogia: string, värv: string, sünniaasta: number) {
        this.nimi = nimi;
        this.hääli = 0;
        this.ideoloogia = ideoloogia;
        this.värv = värv;
        this.sünniaasta = sünniaasta;
    }

    lisaHääl() {
        this.hääli += 1;
    }
}

class Valimiskast {
    kandidaadid: Kandidaat[];

    constructor() {
        this.kandidaadid = [];
    }

    lisaKandidaat(kandidaat: Kandidaat) {
        this.kandidaadid.push(kandidaat);
    }

    hääleta() {
        const juhuslikKandidaatIndex = Math.floor(Math.random() * this.kandidaadid.length);
        const valitudKandidaat = this.kandidaadid[juhuslikKandidaatIndex];
        valitudKandidaat.lisaHääl();
    }

    näitaTulemus() {
        console.log("Valimistulemus:");
        this.kandidaadid.forEach((kandidaat) => {
            console.log(`${kandidaat.nimi}: ${kandidaat.hääli} häält, Ideoloogia: ${kandidaat.ideoloogia}, Värv: ${kandidaat.värv}, Vanus: ${2024 - kandidaat.sünniaasta}`);
        });
    }
}

// Muutujad
const valimised = new Valimiskast();

const kandidaat1 = new Kandidaat("Kandidaat 1", "Liberaalne", "Sinine", 1985);
const kandidaat2 = new Kandidaat("Kandidaat 2", "Konservatiivne", "Punane", 1978);
const kandidaat3 = new Kandidaat("Kandidaat 3", "Progressiivne", "Roheline", 1980);

valimised.lisaKandidaat(kandidaat1);
valimised.lisaKandidaat(kandidaat2);
valimised.lisaKandidaat(kandidaat3);

// Simuleeri hääletamist
for (let i = 0; i < 100; i++) {
    valimised.hääleta();
}

// Näita tulemust
valimised.näitaTulemus();

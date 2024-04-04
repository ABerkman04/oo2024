export interface Purchaseable {
    name: string;
    price: number;
}

export class Item implements Purchaseable {
    constructor(public name: string, public price: number) {}
}
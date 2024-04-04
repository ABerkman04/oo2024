import { Item } from '../purchase';

test('check affordability - enough money', () => {
    const itemPrice = 50;
    const money = 100;
    const itemName = 'Example Item';
    const item = new Item(itemName, itemPrice);

    expect(money >= item.price).toBe(true);
});

test('check affordability - not enough money', () => {
    const itemPrice = 150;
    const money = 100;
    const itemName = 'Example Item';
    const item = new Item(itemName, itemPrice);

    expect(money >= item.price).toBe(false);
});

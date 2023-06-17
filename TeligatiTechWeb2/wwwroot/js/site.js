function getCartFromLS() {
    let savedCart = localStorage.getItem('cart');
    let cart = {};
    if (savedCart) {
        cart = JSON.parse(savedCart);
    }
    return cart;
}

function displayMsg() {
    document.getElementById('cartMsg').style.display = "block";
}

function addToCart(id, name, price, total) {
    console.log(id, name, price, total);
    const cart = getCartFromLS();
    cart[id] = [name, price];
    const cartStringified = JSON.stringify(cart);
    localStorage.setItem('cart', cartStringified);
    displayMsg();
}

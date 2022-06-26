const menu = document.querySelector('.header__menu-group');
const burger = document.querySelector('.burger');

window.addEventListener('resize', function (event) {
    const menu = document.querySelector('.header__menu-group');
    const burger = document.querySelector('.burger');
    let width = this.document.body.clientWidth;
    if (width > 768 && menu.classList.contains('open')) {
        menu.classList.remove('open');
        burger.classList.remove('active');
        ScrollUnlock();
    }
}, true);

function ScrollLock() {
    let pagePosition = window.scrollY;
    document.body.style.position = 'fixed';
    document.body.dataset.position = pagePosition;
    document.body.style.top = - pagePosition + 'px';
    document.documentElement.style.scrollBehavior = 'auto';
}

function ScrollUnlock() {
    let pagePosition = parseInt(document.body.dataset.position, 10);
    document.body.style.position = '';
    document.body.style.top = '';
    window.scrollTo({
        top: pagePosition,
        behavior: "auto"
    });
    document.documentElement.style.scrollBehavior = 'smooth';
}

function Scroll(id) {
    document.getElementById(id).scrollIntoView();
}
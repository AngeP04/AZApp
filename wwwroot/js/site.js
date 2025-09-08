const btn1 = document.getElementById('btn1');
const btn2 = document.getElementById('btn2');
const footer = document.getElementById('footer');

// Scroll vers le bas
btn1.addEventListener('click', () => {
    footer.scrollIntoView({ behavior: 'smooth' });
});

// Scroll vers le haut
btn2.addEventListener('click', () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
});

// Afficher les boutons seulement quand on scroll et pas en bas
window.addEventListener('scroll', () => {
    const scrollTop = window.scrollY;
    const windowHeight = window.innerHeight;
    const footerTop = footer.getBoundingClientRect().top;

    if (scrollTop > 50 && footerTop > windowHeight) {
        btn1.classList.add('show');
        btn2.classList.add('show');
    } else {
        btn1.classList.remove('show');
        btn2.classList.remove('show');
    }
});


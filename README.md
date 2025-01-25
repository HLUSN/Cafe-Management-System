# WEB COFFEE

***Web Coffe using*** HTML, CSS, & Javascript

**Bagian Head**

```head of html
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>De'Paris Cafe</title>
    <!-- Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,300;0,400;0,700;1,100;1,700&display=swap" rel="stylesheet" />
    <!-- Feather Icons -->
    <!-- <script src="https://unpkg.com/feather-icons"></script> -->
    <script src="https://cdn.jsdelivr.net/npm/feather-icons/dist/feather.min.js"></script>
    <!-- icon -->
    <link rel="shortcut icon" href="img/espresso.jpg" type="image/x-icon" />
    <!-- Starability CSS -->
    <link rel="stylesheet" href="css/starability-minified/starability-all.min.css" />
    <!-- My Style -->
    <link rel="stylesheet" href="css/style.css" />
  </head>
```

**Bagian Navbar**

```navbar in html
  <nav class="navbar">
    <a href="#home" class="navbar-logo">De' Paris <span>Cafe</span>.</a>
    <div class="navbar-nav">
      <a href="#home">Home</a>
      <a href="#about">About</a>
      <a href="#menu">Menu</a>
      <a href="#contact">Contact</a>
    </div>
    <div class="navbar-extra">
      <a href="#" id="search"><i data-feather="search"></i></a>
      <a href="#" id="shopping-cart"><i data-feather="shopping-cart"></i></a>
      <a href="#" id="hamburger-menu"><i data-feather="menu"></i></a>
    </div>
  </nav>
```

**Bagian Hero**

```hero section in html
  <section class="hero" id="home">
    <main class="content">
      <h1>Mari Nikmati Secangkir <span>Kopi</span>.</h1>
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Similique, nostrum?</p>
      <a href="#" class="cta">Beli Sekarang</a>
    </main>
  </section>
```

**Bagian About**

```about section in html
  <section class="about" id="about">
    <h2><span>About</span> Us</h2>
    <div class="row">
      <div class="about-img">
        <img src="img/coffe_latte.jpg" alt="Tentang Kami" />
      </div>
      <div class="content">
        <h3>Kenapa memilih <span>kopi</span> kami?</h3>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Consequatur magnam expedita saepe assumenda corrupti rem!</p>
        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Porro quo distinctio dolor deserunt consectetur soluta possimus corporis dolorem officiis omnis?</p>
      </div>
    </div>
  </section>
```

**Bagian Menu**

```menu section in html
  <section class="menu" id="menu">
    <h2><span>Menu</span> Kami.</h2>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Ducimus, assumenda. Deleniti animi voluptatum minima?</p>
    <div class="row">
      <div class="menu-card">
        <img src="img/espresso.jpg" alt="espresso" class="menu-card-image" />
        <h3 class="menu-card-title">- Espresso -</h3>
        <p class="menu-card-price">IDR 15k</p>
      </div>
      <div class="menu-card">
        <img src="img/espresso.jpg" alt="espresso" class="menu-card-image" />
        <h3 class="menu-card-title">- Espresso -</h3>
        <p class="menu-card-price">IDR 15k</p>
      </div>
      <div class="menu-card">
        <img src="img/espresso.jpg" alt="espresso" class="menu-card-image" />
        <h3 class="menu-card-title">- Espresso -</h3>
        <p class="menu-card-price">IDR 15k</p>
      </div>
      <div class="menu-card">
        <img src="img/espresso.jpg" alt="espresso" class="menu-card-image" />
        <h3 class="menu-card-title">- Espresso -</h3>
        <p class="menu-card-price">IDR 15k</p>
      </div>
    </div>
  </section>
```

**Bagian Contact**

```contact section in html
  <section id="contact" class="contact">
    <h2><span>Kontak</span> Kami.</h2>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Assumenda, saepe.</p>
    <div class="row">
      <iframe
        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3989.687740137802!2d117.17040931379827!3d-0.4635546354103913!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x2df678a9d7fd69c3%3A0xcff5345153ae1d6f!2sDe&#39;%20Paris%20Cafe!5e0!3m2!1sid!2sid!4v1674023269999!5m2!1sid!2sid"
        allowfullscreen=""
        loading="lazy"
        referrerpolicy="no-referrer-when-downgrade"
        class="map"
      ></iframe>
      <form action="">
        <div class="input-group">
          <i data-feather="user"></i>
          <input type="text" placeholder="Masukan Nama" name="nama" id="nama" />
        </div>
        <div class="input-group">
          <i data-feather="mail"></i>
          <input type="email" placeholder="Masukan Email" name="email" id="email" />
        </div>
        <div class="input-group">
          <i data-feather="phone"></i>
          <input type="text" placeholder="Masukan Nomor HP" name="no_hp" id="no_hp" />
        </div>
        <div class="input-inline">
          <fieldset class="starability-basic">
            <legend>Rating</legend>
            <input type="radio" id="no-rate" class="input-no-rate" name="rating" value="0" checked aria-label="No rating." />
            <input type="radio" id="first-rate1" name="rating" value="1" />
            <label for="first-rate1" title="Terrible">1 star</label>
            <input type="radio" id="first-rate2" name="rating" value="2" />
            <label for="first-rate2" title="Not good">2 stars</label>
            <input type="radio" id="first-rate3" name="rating" value="3" />
            <label for="first-rate3" title="Average">3 stars</label>
            <input type="radio" id="first-rate4" name="rating" value="4" />
            <label for="first-rate4" title="Very good">4 stars</label>
            <input type="radio" id="first-rate5" name="rating" value="5" />
            <label for="first-rate5" title="Amazing">5 stars</label>
          </fieldset>
        </div>
        <button type="submit" class="btn">Kirim Pesan</button>
      </form>
    </div>
  </section>
```

**Bagian Footer**

```footer section in html
  <footer>
    <div class="socials">
      <a href="https://www.instagram.com/depariscafe/"><i data-feather="instagram"></i></a>
      <a href="https://www.facebook.com/search/top?q=de%27paris%20cafe"><i data-feather="facebook"></i></a>
    </div>
    <div class="links">
      <a href="#home">Home</a>
      <a href="#about">About</a>
      <a href="#menu">Menu</a>
      <a href="#contact">Contact</a>
    </div>
    <div class="credit">
      <p>Created by <a href="https://github.com/satriai0508">Deuwi Satriya Irawan</a>. | &COPY; 2023</p>
    </div>
  </footer>

  <script>
    feather.replace();
  </script>

  <script src="js/script.js"></script>
```

**Tambahkan CSS nya ya :)**

```css
/* Google Fonts */
@import url("https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,300;0,400;0,700;1,100;1,700&display=swap");

/* Reset */
:root {
  --primary: #b6895b;
  --dark: #010101;
  --white: #fff;
}

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  outline: none;
  border: none;
  text-decoration: none;
}

html {
  scroll-behavior: smooth;
}

body {
  font-family: "Poppins", sans-serif;
  background-color: var(--dark);
  color: var(--white);
  /* min-height: 5000px; */
}
/* Reset */

/* Navbar */
.navbar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1.4rem 7%;
  background-color: rgba(1, 1, 1, 0.8);
  border-bottom: 1px solid #513c28;
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  z-index: 99999999;
}

.navbar .navbar-logo {
  font-size: 2rem;
  font-weight: 700;
  font-style: italic;
  color: var(--white);
}

.navbar .navbar-logo span {
  color: var(--primary);
}

.navbar .navbar-nav a {
  color: var(--white);
  display: inline-block;
  font-size: 1.3rem;
  margin: 0 1rem;
}

.navbar .navbar-nav a:hover {
  color: var(--primary);
}

.navbar .navbar-nav a::after {
  content: "";
  display: block;
  padding-bottom: 0.5rem;
  border-bottom: 0.1rem solid var(--primary);
  transform: scaleX(0);
  transition: 0.2s linear;
}

.navbar .navbar-nav a:hover::after {
  transform: scaleX(0.5);
}

.navbar .navbar-extra a {
  color: var(--white);
  margin: 0 0 0.5rem;
}

.navbar .navbar-extra a:hover {
  color: var(--primary);
}

#hamburger-menu {
  display: none;
}
/* Navbar */

/* Hero */
.hero {
  min-height: 100vh;
  display: flex;
  align-items: center;
  background-image: url("../img/coffe-flip.jpg");
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center;
  position: relative;
}

.hero::after {
  content: "";
  display: block;
  position: absolute;
  width: 100%;
  height: 30%;
  bottom: 0;
  background: linear-gradient(0deg, rgba(1, 1, 3, 1) 8%, rgba(255, 255, 255, 0) 50%);
}

.hero .content {
  padding: 1.4rem 7%;
  max-width: 60rem;
}

.hero .content h1 {
  font-size: 5em;
  color: var(--white);
  text-shadow: 1px 1px 3px rgba(1, 1, 3, 0.5);
  line-height: 1.2;
}

.hero .content h1 span {
  color: var(--primary);
}

.hero .content p {
  font-size: 1.6rem;
  margin-top: 0.5rem;
  line-height: 1.4;
  font-weight: 100;
  text-shadow: 1px 1px 3px rgba(1, 1, 3, 0.5);
  mix-blend-mode: difference;
}

.hero .content .cta {
  margin-top: 1rem;
  display: inline-block;
  padding: 1rem 3rem;
  font-size: 1.4rem;
  color: var(--white);
  background-color: var(--primary);
  border-radius: 0.5rem;
  box-shadow: 1px 1px 3px rgba(1, 1, 3, 0.5);
}
/* Hero */

/* About Us */
.about,
.menu,
.contact {
  padding: 10rem 7% 1.4rem;
}

.about h2,
.menu h2,
.contact h2 {
  text-align: center;
  font-size: 2.6rem;
  margin-bottom: 8rem;
}

.about h2 span,
.menu h2 span,
.contact h2 span {
  color: var(--primary);
}

.about .row {
  display: flex;
}

.about .row .about-img {
  flex: 1 1 45rem;
}

.about .row .about-img img {
  width: 100%;
}

.about .row .content {
  flex: 1 1 35rem;
  padding: 0 1rem;
}

.about .row .content h2 {
  font-size: 1.8rem;
  margin-bottom: 1rem;
}

.about .row .content h2 span {
  color: var(--primary);
}

.about .row .content h3 span {
  color: var(--primary);
}

.about .row .content p {
  font-size: 1.4rem;
  font-weight: 100;
  margin-bottom: 0.8rem;
  line-height: 1.6;
}
/* About Us */

/* Menu */
.menu h2,
.contact h2 {
  margin-bottom: 1rem;
}

.menu p,
.contact p {
  margin: auto;
  text-align: center;
  max-width: 30rem;
  font-weight: 100;
  line-height: 1.6;
}

.menu .row {
  display: flex;
  flex-wrap: wrap;
  margin-top: 5rem;
  justify-content: center;
}

.menu .row .menu-card {
  text-align: center;
  padding-bottom: 4rem;
}

.menu .row .menu-card img {
  border-radius: 50%;
  width: 80%;
}

.menu .row .menu-card .menu-card-title {
  margin: 1rem auto 0.5rem;
}
/* Menu */

/* Contact */
.contact .row {
  display: flex;
  margin-top: 2rem;
  background-color: #222;
  /* flex-wrap: wrap; */
}

.contact .row .map {
  flex: 1 1 45rem;
  width: 100%;
  object-fit: cover;
}

.contact .row form {
  flex: 1 1 45rem;
  padding: 5rem 2rem;
  text-align: center;
}

.contact .row form .input-group {
  display: flex;
  align-items: center;
  margin-top: 2rem;
  background-color: var(--dark);
  border: 1px solid #eee;
  padding-left: 2rem;
  border-radius: 2rem;
}

.contact .row form .input-inline {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: center;
  margin-top: 1rem;
  padding: 1rem 3rem;
}

.contact .row form .input-group input {
  width: 100%;
  padding: 2rem;
  font-size: 1.7rem;
  background: none;
  color: #fff;
}

.contact .row form .btn {
  cursor: pointer;
  margin-top: 1rem;
  display: inline-block;
  padding: 1rem 3rem;
  font-size: 1.7rem;
  border-radius: 2rem;
  background-color: var(--primary);
  color: var(--white);
}
/* Contact */

/* Footer */
footer {
  background-color: var(--primary);
  text-align: center;
  padding: 1rem 3rem;
  margin-top: 3rem;
}

footer .socials {
  padding: 1rem 0;
}

footer .socials a {
  color: var(--white);
  margin: 1rem;
}

footer .socials a:hover,
footer .links a:hover {
  color: var(--dark);
}

footer .links {
  margin-bottom: 1.6rem;
}

footer .links a {
  color: var(--white);
  padding: 0.7rem 1rem;
}

footer .credit {
  font-size: 0.8rem;
}

footer .credit a {
  color: var(--dark);
  font-weight: 700;
}
/* Footer */

/* Media Query */
/* Laptop */
@media (max-width: 1366px) {
  html {
    font-size: 75%;
  }
}
/* Tablet */
@media (max-width: 768px) {
  html {
    font-size: 62.5%;
  }

  #hamburger-menu {
    display: inline-block;
  }

  .navbar .navbar-nav {
    position: absolute;
    top: 100%;
    right: -100%;
    background-color: var(--white);
    width: 30rem;
    height: 100vh;
    transition: 0.4s;
  }

  .navbar .navbar-nav.active {
    right: 0;
  }

  .navbar .navbar-nav a {
    color: var(--dark);
    display: block;
    margin: 1.5rem;
    padding: 0.5rem;
    font-size: 2rem;
  }

  .navbar .navbar-nav a::after {
    transform-origin: 0 0;
  }

  .navbar .navbar-nav a:hover::after {
    transform: scaleX(0.2);
  }

  .about .row {
    flex-wrap: wrap;
  }

  .about .row .content {
    padding: 0;
  }

  .about .row .content h3 {
    margin-top: 1rem;
    font-size: 1.6rem;
  }

  .about .row .about-img img {
    height: 24rem;
    object-fit: cover;
    object-position: center;
  }

  .menu p {
    font-size: 1.2rem;
  }

  .contact .row {
    flex-wrap: wrap;
  }

  .contact .row .map {
    height: 30rem;
  }

  .contact .row form {
    padding-top: 0;
  }
}

/* Mobile */
@media (max-width: 450px) {
  html {
    font-size: 55%;
  }
}
/* Media Query */
```

**Tambahkan sedikit javascript, kalau cuma html sama css aja kurang. Ibarat sayur tanpa garam.**

```javascript
const navbarNav = document.querySelector(".navbar-nav");

const hamburgerMenu = document.querySelector("#hamburger-menu");
hamburgerMenu.onclick = () => {
  navbarNav.classList.toggle("active");
};

document.addEventListener("click", function (e) {
  if (!hamburgerMenu.contains(e.target) && !navbarNav.contains(e.target)) {
    navbarNav.classList.remove("active");
  }
});
```

Hasil jadinya

![De'Paris Cafe!](img/De-Paris-Cafe.png "Landing Page Web Cafe")

Hasil jadi yang di hosting di Github Pages [De'Paris Cefe](https://satriai0508.github.io/web-paris-cafe)

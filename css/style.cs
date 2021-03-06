@charset "UTF-8";
/* 文字コードの指定 */
@import url("https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100;300;400;500;700;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Roboto+Condensed:ital,wght@0,300;0,400;0,700;1,300;1,400;1,700&display=swap");
html {
  font-size: 62.5%;
}

body {
  font-family: "Noto Sans JP", sans-serif;
  font-size: 1.5rem;
  font-weight: 400;
  line-height: 1.75;
  color: #000000;
  background-color: #ffffff;
}
@media (min-width: 769px) {
  body {
    font-size: 1.6rem;
  }
}

a {
  color: #000000;
  text-decoration: none;
}

img {
  max-width: 100%;
  vertical-align: bottom;
}

.header {
  top: 0;
  align-items: center;
  justify-content: space-between;
  z-index: 4;
  width: 100%;
  height: 6rem;
  background-color: #000000;
  box-sizing: border-box;
  position: fixed;
  background-color: rgba(0, 0, 0, 0.7);
}
@media (min-width: 769px) {
  .header {
    height: 5rem;
    padding-top: 10px;
  }
}
@media (max-width: 768px) {
  .header {
    display: flex;
  }
}

.header-inner {
  display: block;
  top: 0;
  align-items: center;
  justify-content: space-between;
  z-index: 3;
  width: 100%;
  height: 6rem;
  padding: 1rem 0 0 0rem;
  background-color: #000000;
  box-sizing: border-box;
  position: fixed;
  background-color: rgba(0, 0, 0, 0.7);
  display: flex;
  padding-left: 10px;
}
@media (min-width: 769px) {
  .header-inner {
    display: none;
  }
}

.logo {
  display: inherit;
  padding: 0 0 0 30px;
}
@media (min-width: 769px) {
  .logo {
    float: left;
  }
}
@media (max-width: 768px) {
  .logo {
    padding: 0 0 0 20px;
  }
}
.logo .logo-about {
  display: inherit;
  padding: 0 0 0 30px;
}
@media (min-width: 769px) {
  .logo .logo-about {
    float: left;
  }
}
@media (max-width: 768px) {
  .logo .logo-about {
    padding: 0 0 0 25px;
  }
}
@media (max-width: 768px) {
  .logo a.logo-about {
    padding-left: 30px;
  }
}
.logo a.logo {
  height: 30px;
}
@media (min-width: 769px) {
  .logo a.logo {
    height: 30px;
    margin-left: 120px;
  }
}
@media (max-width: 768px) {
  .logo a.logo {
    margin-left: 15px;
  }
}

.logo-2 {
  display: block;
  display: inherit;
  margin: 0;
  margin-left: 20px;
}
@media (max-width: 768px) {
  .logo-2 {
    margin-left: 20px;
  }
}
.logo-2 a.logo {
  height: 30px;
}
@media (min-width: 769px) {
  .logo-2 a.logo {
    height: 25px;
  }
}

.nav-button {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 6rem;
  height: 6rem;
  font-size: 3.1rem;
  color: #b19833;
  cursor: pointer;
  margin-left: 0px;
  margin-right: 0px;
}
@media (min-width: 769px) {
  .nav-button {
    display: none;
  }
}
@media (max-width: 768px) {
  .nav-button {
    margin-right: 20px;
  }
}

.sp-nav {
  position: absolute;
  top: 6rem;
  left: 0;
  display: none;
  z-index: 4;
  width: 100%;
  padding: 3rem;
  font-size: 2.4rem;
  text-align: center;
  background-color: black;
  border-top: 1px solid #000000;
  box-sizing: border-box;
  background-color: rgba(0, 0, 0, 0.9);
}

.sp-nav-list {
  padding: 0;
  margin: 40px 0 0px 0;
  list-style: none;
}
.sp-nav-list li {
  font-size: 40px;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
  margin-bottom: 55px;
}
.sp-nav-list li a {
  color: #b19833;
}

.pc-nav {
  display: none;
}
@media (min-width: 769px) {
  .pc-nav {
    display: block;
    justify-content: space-between;
  }
}

.pc-nav-list {
  display: flex;
  align-items: center;
  height: 100%;
  padding: 0;
  margin: 0;
  list-style: none;
}
.pc-nav-list li {
  margin: 0 0 0 0rem;
}
@media (min-width: 769px) {
  .pc-nav-list {
    max-width: 1080px;
    margin-left: auto;
    margin-right: auto;
    padding: 0;
  }
}

.pc-nav ul li a {
  text-decoration: none;
  color: #b19833;
  margin: 0 10rem 0 0rem;
}
@media (min-width: 769px) {
  .pc-nav ul li a {
    text-align: right;
    margin: 0 3rem 0 0rem;
    font-size: 20px;
    font-family: "Roboto Condensed", sans-serif;
    font-weight: 700;
  }
}

@media (min-width: 769px) {
  .set-width {
    max-width: 1080px;
    margin-left: auto;
    margin-right: auto;
  }
}

.cover {
  display: relative;
  z-index: 1;
  top: 50%;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  color: #ffffff;
  background-size: cover;
  background-position: center;
}
@media (min-width: 769px) {
  .cover {
    height: 760px;
    box-sizing: border-box;
    margin-bottom: 120px;
  }
}

.cover-title {
  position: absolute;
  top: 45%;
  left: 50%;
  -ms-transform: translate(-50%, -50%);
  -webkit-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  margin: 0;
  padding: 0;
  z-index: 2;
  width: 100%;
  text-align: center;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
  font-size: 32px;
}
@media (min-width: 769px) {
  .cover-title {
    font-size: 5rem;
    margin-top: 8rem;
    position: absolute;
    top: 25%;
    left: 50%;
    font-size: 80px;
  }
}

.cover-discription {
  position: absolute;
  top: 48%;
  left: 50%;
  -ms-transform: translate(-50%, -50%);
  -webkit-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  z-index: 3;
  text-align: center;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
  font-size: 24px;
  white-space: nowrap;
}
@media (min-width: 769px) {
  .cover-discription {
    font-size: 3rem;
    position: absolute;
    top: 45%;
    left: 50%;
    font-size: 48px;
  }
}

.sub-cover {
  display: relative;
  z-index: 1;
  top: 50%;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  padding-top: 6rem;
  color: #ffffff;
  background-size: cover;
  background-position: center;
  background-image: url("../images/cover/cover_info.jpg");
  height: 15rem;
}
@media (min-width: 769px) {
  .sub-cover {
    margin-bottom: 120px;
    height: 400px;
    box-sizing: border-box;
  }
}

.sub-cover-2 {
  display: relative;
  z-index: 1;
  top: 50%;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  padding-top: 6rem;
  color: #ffffff;
  background-size: cover;
  background-position: center;
  background-image: url("../images/cover/cover_about.jpg");
  height: 15rem;
}
@media (min-width: 769px) {
  .sub-cover-2 {
    height: 400px;
    box-sizing: border-box;
    margin-bottom: 120px;
  }
}

.sub-cover-3 {
  display: relative;
  z-index: 1;
  top: 50%;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  padding-top: 6rem;
  color: #ffffff;
  background-size: cover;
  background-position: center;
  background-image: url("../images/cover/cover_menu.jpg");
  height: 15rem;
}
@media (min-width: 769px) {
  .sub-cover-3 {
    height: 400px;
    box-sizing: border-box;
    margin-bottom: 120px;
  }
}

.sub-cover-title {
  position: absolute;
  top: 16%;
  left: 50%;
  -ms-transform: translate(-50%, -50%);
  -webkit-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  margin: 0;
  padding: 0;
  z-index: 2;
  width: 100%;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
  text-align: center;
  font-size: 3rem;
  font-weight: 700;
}
@media (min-width: 769px) {
  .sub-cover-title {
    font-size: 72px;
    margin-top: 8rem;
  }
}

@media (min-width: 769px) {
  .main {
    width: 70%;
  }
}

.section-heading {
  text-align: left;
}
@media (min-width: 769px) {
  .section-heading {
    margin: 0rem 0rem 0rem 0rem;
  }
}

.section-viewall a {
  float: right;
  margin: 3rem 3rem 0 0rem;
  font-size: 1.5rem;
  font-weight: 500;
  color: #b19833;
}
@media (min-width: 769px) {
  .section-viewall a {
    float: left;
    margin: 4rem 3rem 0 3rem;
    font-size: 1.5rem;
  }
}

.section-title {
  display: inline-block;
  float: left;
  margin: 0rem 0 0rem 3rem;
  font-size: 2.2rem;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
  line-height: 1;
}
@media (min-width: 769px) {
  .section-title {
    margin: 3rem 0rem 5rem 0rem;
    font-size: 3.5rem;
  }
}
@media (max-width: 768px) {
  .section-title {
    margin: 3rem 0rem 20px 20px;
    font-size: 28px;
  }
}

.section-heading2 {
  text-align: left;
}
@media (min-width: 769px) {
  .section-heading2 {
    margin: 0rem 0rem 0rem 2rem;
  }
}

.section-title2 {
  text-align: left;
  font-family: "Roboto Condensed", sans-serif;
  font-size: 2.2rem;
  font-weight: 700;
}
@media (min-width: 769px) {
  .section-title2 {
    margin: 2rem 0 25px 120px;
    font-size: 24px;
  }
}

.section-title2-shop {
  text-align: left;
  font-family: "Roboto Condensed", sans-serif;
  font-size: 2.2rem;
  font-weight: 700;
}
@media (min-width: 769px) {
  .section-title2-shop {
    margin: 2rem 0 25px 120px;
    font-size: 24px;
  }
}

.section-title3 {
  text-align: left;
  margin: 3rem 0rem 1rem 3rem;
  font-family: "Roboto Condensed", sans-serif;
  font-size: 2.2rem;
  font-weight: 700;
}
@media (min-width: 769px) {
  .section-title3 {
    margin: 2rem 0 25px 0rem;
    font-size: 24px;
  }
}

.service {
  width: 100%;
}
@media (min-width: 769px) {
  .service {
    padding-bottom: 5rem;
    display: flex;
  }
}

.service-2 {
  width: 100%;
}
@media (min-width: 769px) {
  .service-2 {
    display: flex;
  }
}

.service-item {
  display: flex;
  width: 47%;
}
@media (min-width: 769px) {
  .service-item {
    justify-content: space-between;
    width: 23%;
    box-sizing: border-box;
    padding: 0;
    margin-right: 2rem;
  }
}
@media (max-width: 768px) {
  .service-item {
    padding-right: 2rem;
  }
}

@media (max-width: 768px) {
  .service-item:nth-child(1) {
    padding-left: 0;
  }
}

@media (max-width: 768px) {
  .service-item:nth-child(2) {
    padding-right: 0;
  }
}

.service-item:nth-child(3) {
  padding-left: 0;
}

.service-item:nth-child(4) {
  padding-right: 0;
}

.service-item-2 {
  display: flex;
  width: 44%;
  padding: 0 1rem;
  margin: 0 0rem;
}
@media (min-width: 769px) {
  .service-item-2 {
    justify-content: space-between;
    width: 225px;
    box-sizing: border-box;
    padding: 0;
    margin-right: 20px;
  }
}

.service-item-full {
  width: 100%;
}

.service-item-full img {
  width: 100%;
}

.service-item-half {
  width: 49%;
}

.service-item-half:nth-child(2n) {
  padding: 0 2% 0 0;
}

.service-item-half img {
  width: 100%;
}

.service-item-half {
  width: 24.25%;
}

.service-item-half:nth-child(2n), .gallery-box-half {
  padding: 0 1% 0 0;
}

.service-item-half:last-child {
  padding: 0 0 0 0;
}

.service-title {
  padding: 0rem 0rem 0rem;
  margin: 1rem 1rem 0 1rem;
  color: #777777;
}
@media (min-width: 769px) {
  .service-title {
    font-size: 1.5rem;
    margin: 0 0 0 1rem;
    font-weight: 700;
  }
}

.service-text {
  padding: 0 0rem 0rem;
  margin: 0 1rem 2rem 1rem;
}
@media (min-width: 769px) {
  .service-text {
    margin: 0 0 2rem 1rem;
    width: 96%;
    font-weight: 400;
    font-size: 16px;
  }
}

.service-img {
  box-shadow: 0 0 1.3rem rgba(0, 0, 0, 0.1);
}
@media (min-width: 769px) {
  .service-img {
    box-shadow: 0 0 1.3rem rgba(0, 0, 0, 0.1);
  }
}
@media (max-width: 768px) {
  .service-img {
    box-shadow: 0 0 1.3rem rgba(0, 0, 0, 0.1);
  }
}

@media (min-width: 769px) {
  .shop {
    text-align: left;
  }
}

@media (min-width: 769px) {
  .shop-2 {
    float: left;
    text-align: left;
    border-top: solid #777 thin;
    margin-bottom: 50px;
  }
}

.shop-bg {
  padding: 3rem 3rem 7rem 3rem;
  font-size: 1.4rem;
  background-color: #b19833;
}
@media (min-width: 769px) {
  .shop-bg {
    height: 330px;
    padding: 55px 3rem 0px 3rem;
  }
}

.shop-logo {
  clear: both;
  margin-bottom: 3.5rem;
  align-items: left;
}
@media (min-width: 769px) {
  .shop-logo {
    margin-bottom: 4rem;
    text-align: center;
  }
}

.box {
  border: 1px solid;
  margin: 0 auto;
  width: 250px;
  color: #ebd47a;
  border-left: transparent;
  border-right: transparent;
  font-weight: 400;
}
@media (min-width: 769px) {
  .box {
    display: flex;
    margin-bottom: 4rem;
    width: 500px;
  }
}

.box-2 {
  border: 1px solid;
  margin: 0 auto;
  width: 250px;
  color: #ffffff;
  border-left: transparent;
  border-right: transparent;
}
@media (min-width: 769px) {
  .box-2 {
    display: flex;
    margin-bottom: 4rem;
    width: 500px;
  }
}

.box-3 {
  width: 100%;
  padding-left: 0rem;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .box-3 {
    justify-content: space-between;
    font-size: 1.5rem;
    padding-left: 0rem;
    margin: 0rem 0 1rem 0;
  }
}

.shop_inline-block1 {
  margin: 1rem 1rem 0 5rem;
  color: #ffffff;
  float: left;
}
@media (min-width: 769px) {
  .shop_inline-block1 {
    margin-left: 50px;
    margin: 1rem 2rem 1rem 6rem;
  }
}

.shop_inline-block2 {
  margin: 1rem 0 0 4rem;
  color: #ffffff;
}
@media (min-width: 769px) {
  .shop_inline-block2 {
    float: left;
    margin: 1rem 7rem 1rem 0;
  }
}

.shop_inline-block3 {
  margin: 0 1rem 1rem 5rem;
  color: #ffffff;
  float: left;
}
@media (min-width: 769px) {
  .shop_inline-block3 {
    float: left;
    margin: 1rem 2rem 1rem 0;
  }
}

.shop_inline-block4 {
  margin: 0 0 1rem 4rem;
  color: #ffffff;
}
@media (min-width: 769px) {
  .shop_inline-block4 {
    float: left;
    margin: 1rem 0 1rem 0;
  }
}

.shop_inline-block1-2 {
  float: left;
  color: black;
  display: flex;
  margin: 0rem 1rem 0rem 10rem;
}
@media (min-width: 769px) {
  .shop_inline-block1-2 {
    display: flex;
    margin: 0rem 1rem 0rem 0rem;
  }
}

.shop_inline-block2-2 {
  margin: 1rem 0 0 4rem;
  color: black;
}
@media (min-width: 769px) {
  .shop_inline-block2-2 {
    width: 100%;
  }
}

.shop_inline-block3-2 {
  margin: 0 1rem 1rem 10rem;
  float: left;
  color: black;
}
@media (min-width: 769px) {
  .shop_inline-block3-2 {
    display: flex;
    margin: 0rem 1rem 0rem 0rem;
  }
}

.shop_inline-block4-2 {
  margin: 0 0 1rem 4rem;
  color: black;
}
@media (min-width: 769px) {
  .shop_inline-block4-2 {
    width: 100%;
  }
}

#shop_inline-block1-3 p {
  margin: 15px 0 0 45px;
  padding: 0;
  color: #ffffff;
  float: left;
  font-size: 14px;
  text-align: center;
  line-height: 1em;
}

#shop_inline-block2-3 p {
  margin: 15px 0 0 0px;
  padding: 0;
  color: #ffffff;
  font-size: 14px;
  text-align: center;
  line-height: 1em;
}

#shop_inline-block3-3 p {
  margin: 0px 0 0 45px;
  padding: 0;
  color: #ffffff;
  float: left;
  font-size: 14px;
  text-align: center;
  line-height: 1em;
}

#shop_inline-block4-3 p {
  padding: 0;
  color: #ffffff;
  font-size: 14px;
  text-align: center;
  line-height: 1em;
}

.up {
  border-top: solid #b19833 thin;
  width: 235px;
  text-align: center;
  margin-left: 30px;
}

.down {
  border-bottom: solid #b19833 thin;
  width: 235px;
  margin-left: 30px;
}

.shop-info {
  color: #ffffff;
}
.shop-info .shop-info1 {
  display: block;
  text-align: left;
  margin-top: 2rem;
  float: left;
}
.shop-info .shop-info2 {
  display: none;
}
@media (min-width: 769px) {
  .shop-info .shop-info1 {
    display: none;
  }
  .shop-info .shop-info2 {
    display: block;
    text-align: center;
  }
}

.shop-info2 {
  margin-bottom: 70px;
}
@media (max-width: 768px) {
  .shop-info2 {
    float: left;
  }
}

.shop-info-2 {
  color: black;
}
.shop-info-2 .shop-info1 {
  display: block;
  text-align: left;
  margin-top: 1rem;
  padding-left: 3rem;
  float: left;
}
.shop-info-2 .shop-info2 {
  display: none;
}
@media (min-width: 769px) {
  .shop-info-2 .shop-info1 {
    display: none;
  }
  .shop-info-2 .shop-info2 {
    display: block;
    text-align: center;
  }
}

.shop-info-3 {
  color: black;
  padding-left: 3rem;
}
@media (min-width: 769px) {
  .shop-info-3 {
    display: block;
    padding-left: 0rem;
  }
}

.shop-info-hamburger {
  margin: 15px 0 0 0rem;
  padding: 0;
  color: #ffffff;
  float: left;
  font-size: 14px;
  text-align: left;
  line-height: 1em;
}

#google_map {
  width: 100%;
  height: 250px;
}
@media (min-width: 769px) {
  #google_map {
    width: 100%;
    height: 390px;
  }
}

.about {
  clear: both;
}
@media (min-width: 769px) {
  .about {
    padding-bottom: 5rem;
    display: flex;
    box-sizing: border-box;
  }
}

.about-item {
  width: 100%;
}
@media (min-width: 769px) {
  .about-item {
    padding-top: 0rem;
    padding-bottom: 0rem;
    float: left;
    box-sizing: border-box;
    text-align: center;
  }
}

.about-item-2 {
  width: 100%;
}
@media (min-width: 769px) {
  .about-item-2 {
    width: 50rem;
    padding-top: 0rem;
    padding-bottom: 0rem;
    float: left;
    box-sizing: border-box;
    text-align: center;
  }
}

.about-text {
  margin: 20px 0 45px 0;
  width: 95%;
}
.about-text .about-text2 {
  display: none;
}
@media (min-width: 769px) {
  .about-text {
    width: 100%;
    font-size: 16px;
  }
  .about-text .about-text1 {
    display: block;
    text-align: left;
    margin-top: 2rem;
  }
  .about-text .about-text2 {
    display: block;
    text-align: left;
  }
}

.about-text-2 {
  margin: 0 auto;
  width: 95%;
}
.about-text-2 .about-text2 {
  display: none;
}
@media (min-width: 769px) {
  .about-text-2 {
    width: 50rem;
    padding: 0rem 0rem 0rem 0rem;
    margin: 0px 0 0 55px;
    font-size: 16px;
  }
  .about-text-2 .about-text1 {
    display: block;
    text-align: left;
    margin-bottom: 20px;
  }
  .about-text-2 .about-text2 {
    display: block;
    text-align: left;
    margin-bottom: 20px;
  }
}

@media (min-width: 769px) {
  .container {
    margin-left: auto;
    margin-right: auto;
    margin-top: 0;
    margin-bottom: 0;
    max-width: 1080px;
    clear: both;
  }
}

@media (min-width: 769px) {
  .section-tille2-container {
    margin-left: auto;
    margin-right: auto;
    margin-top: 0;
    margin-bottom: 0;
    max-width: 1080px;
    clear: both;
  }
}

@media (min-width: 769px) {
  .container-about {
    max-width: 100%;
    margin: 0 0rem 0 0rem;
    clear: both;
  }
}

.container-2colum {
  padding-top: 4rem;
}
@media (min-width: 769px) {
  .container-2colum {
    max-width: 100%;
    margin: 0 140px 0 140px;
    padding-top: 0rem;
  }
}

.container-old {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container-old {
    padding: 0;
    margin: 0;
    width: 740px;
  }
}

.container-old-top {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container-old-top {
    padding: 0;
    margin: 0;
    width: 1080px;
  }
}

.container-old-top {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container-old-top {
    padding: 0;
    margin: 0;
    width: 1080px;
  }
}

.container-old-2 {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container-old-2 {
    flex-direction: row;
    width: 740px;
    padding: 0;
    margin-bottom: 48px;
  }
}

@media (min-width: 769px) {
  .container-2 {
    padding: 0 3rem 0 3rem;
  }
}

.container2-old {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container2-old {
    text-align: center;
    padding: 0;
    margin: 0;
    flex-direction: row-reverse;
    width: 740px;
  }
}

.container2-old-top {
  clear: both;
  display: flex;
  flex-wrap: wrap;
  padding: 0 2rem;
  margin: 0 auto;
  box-sizing: border-box;
}
@media (min-width: 769px) {
  .container2-old-top {
    text-align: center;
    padding: 0;
    margin: 0;
    flex-direction: row-reverse;
    width: 1080px;
  }
}

.img-wide1 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .img-wide1 {
    display: inline-block;
    margin: 0rem 0rem 0rem 0rem;
  }
}

.img-wide2 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .img-wide2 {
    float: right;
    margin: 0rem 0rem 0rem 0rem;
  }
}

.footer {
  padding: 1rem 0rem 1rem 0rem;
  font-size: 12px;
  background-color: #333333;
  height: 55px;
}
@media (min-width: 769px) {
  .footer {
    height: 3rem;
    line-height: 50%;
  }
}

.copyright {
  text-align: center;
  color: #ffffff;
}

.sns {
  text-align: right;
  padding: 0;
  list-style: none;
}
@media (min-width: 769px) {
  .sns {
    text-align: center;
  }
}
.sns li {
  display: inline-block;
  text-align: center;
  margin-top: 1.5rem;
  width: 3rem;
  height: 3rem;
  font-size: 1.5rem;
  color: #ebd47a;
  background-color: #ffffff;
  border-radius: 50%;
}
.sns li:first-child {
  margin-right: 1rem;
}
.sns li:last-child {
  margin-left: 1rem;
}
@media (min-width: 769px) {
  .sns li {
    text-align: center;
    width: 5rem;
    height: 5rem;
    font-size: 2.7rem;
  }
}
.sns a {
  color: #b19833;
}

.sns-2 {
  text-align: right;
  margin: 0 20px 0px 0;
  list-style: none;
  float: right;
  padding-left: 0;
}
@media (min-width: 769px) {
  .sns-2 {
    padding-left: 0;
    text-align: left;
  }
}
.sns-2 li {
  display: inline-block;
  text-align: center;
  margin-top: 1.5rem;
  width: 3rem;
  height: 3rem;
  font-size: 1.5rem;
  background-color: #b19833;
  border-radius: 50%;
}
.sns-2 li:first-child {
  margin-right: 1rem;
}
.sns-2 li:last-child {
  margin-left: 1rem;
}
@media (min-width: 769px) {
  .sns-2 li {
    text-align: center;
    width: 35px;
    height: 35px;
    font-size: 20px;
  }
}
.sns-2 a {
  color: #ffffff;
}

.sns-3 {
  text-align: right;
  padding: 0;
  margin: 15px 0 0 0;
  list-style: none;
  display: inline-flex;
}
@media (min-width: 769px) {
  .sns-3 {
    text-align: center;
  }
}
.sns-3 li {
  display: inline-block;
  text-align: center;
  margin-top: 0;
  width: 3rem;
  height: 3rem;
  font-size: 1.5rem;
  color: #ebd47a;
  background-color: #ffffff;
  border-radius: 50%;
}
.sns-3 li:first-child {
  margin-right: 0.5rem;
}
.sns-3 li:last-child {
  margin-left: 0.5rem;
}
.sns-3 a {
  color: #b19833;
}

.sns-item-2 {
  margin: 0 30px 45px 30px;
}
@media (min-width: 769px) {
  .sns-item-2 {
    margin-bottom: 110px;
    width: 260px;
    margin: 0px 0px 45px 0px;
  }
}

/*カルーセル*/
.carousel-pc {
  display: none;
}

@media (min-width: 769px) {
  .carousel-pc {
    display: block;
  }
}
.carousel-sp {
  display: none;
}

@media (max-width: 769px) {
  .carousel-sp {
    display: block;
  }
}
.slick-dots {
  bottom: 25px;
}

.slick-dots li.slick-active button:before {
  color: #b19833;
}

.slick-dots li button:before {
  color: #d1d1d0;
}

.menu {
  clear: both;
  width: 100%;
}
@media (min-width: 769px) {
  .menu {
    padding-bottom: 5rem;
    display: flex;
    box-sizing: border-box;
  }
}

.menu-item {
  width: 100%;
}
@media (min-width: 769px) {
  .menu-item {
    padding-top: 0rem;
    padding-bottom: 0rem;
    float: left;
    box-sizing: border-box;
    width: 730px;
  }
}

.menu-item-2 {
  width: 100%;
}
@media (min-width: 769px) {
  .menu-item-2 {
    width: 50rem;
    padding-top: 0rem;
    padding-bottom: 0rem;
    box-sizing: border-box;
    width: 730px;
  }
}

.menu-body-1 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .menu-body-1 {
    margin: 0;
  }
}

.menu-body-2 {
  display: flex;
}
@media (min-width: 769px) {
  .menu-body-2 {
    justify-content: space-between;
    margin-top: 2rem;
  }
}

.menu-body-3 {
  display: inline;
  justify-content: space-between;
  margin: 8px;
  margin-top: 0;
  width: 24%;
}
@media (min-width: 769px) {
  .menu-body-3 {
    width: 23%;
    margin: 0rem;
  }
}

.menu-text {
  margin: 0 auto;
}
.menu-text .menu-text2 {
  display: none;
}
@media (min-width: 769px) {
  .menu-text {
    width: 45%;
    padding: 0rem 2rem 0rem 2rem;
  }
  .menu-text .menu-text1 {
    display: block;
    text-align: left;
    margin-top: 2rem;
  }
  .menu-text .menu-text2 {
    display: block;
    text-align: left;
  }
}

.menu-text-2 {
  margin: 0 auto;
  width: 95%;
}
.menu-text-2 .menu-text2 {
  display: none;
}
@media (min-width: 769px) {
  .menu-text-2 {
    width: 50rem;
    padding: 0rem 0rem 0rem 0rem;
    margin: 55px 55px 0 0px;
  }
  .menu-text-2 .menu-text1 {
    display: block;
    text-align: left;
    margin-bottom: 20px;
  }
  .menu-text-2 .menu-text2 {
    display: block;
    text-align: left;
    margin-bottom: 20px;
  }
}

.menu-table {
  width: 730px;
}

.title-box {
  border: 1px solid;
  margin: 0 auto;
  border-color: #b19833;
  border-top: transparent;
  border-left: transparent;
  border-right: transparent;
}
@media (min-width: 769px) {
  .title-box {
    width: 100%;
    text-align: left;
    margin: 0;
    padding: 0;
  }
}

.title-box-drink {
  border: 1px solid;
  margin: 0 auto;
  border-color: #b19833;
  border-top: transparent;
  border-left: transparent;
  border-right: transparent;
}
@media (min-width: 769px) {
  .title-box-drink {
    width: 100%;
    text-align: left;
    margin: 0;
    padding: 0;
  }
}
@media (max-width: 768px) {
  .title-box-drink {
    margin-top: 30px;
  }
}

.table-title-eng {
  float: left;
  display: inline-block;
  margin-right: 2rem;
}
@media (min-width: 769px) {
  .table-title-eng {
    float: none;
    line-height: 1em;
  }
}

.table-title-eng-drink {
  float: left;
  display: inline-block;
  margin-right: 2rem;
}
@media (min-width: 769px) {
  .table-title-eng-drink {
    float: none;
    line-height: 1em;
  }
}
@media (min-width: 769px) {
  .table-title-eng-drink {
    float: none;
    line-height: 1em;
    margin-top: 30px;
  }
}

h2.table-title-eng {
  margin-top: 0rem;
  margin-bottom: 0px;
  font-size: 2.2rem;
  font-weight: 700;
  font-family: "Roboto Condensed", sans-serif;
}
@media (min-width: 769px) {
  h2.table-title-eng {
    font-size: 36px;
  }
}

.table-title-jp {
  display: inline-block;
  color: #b19833;
}
p.table-title-jp {
  margin-top: 7px;
  margin-bottom: 5px;
}
@media (min-width: 769px) {
  p.table-title-jp {
    margin: 0;
  }
}

.table-1 {
  display: block;
  width: 100%;
  padding-bottom: 5rem;
}
.menu-1 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 2rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-1 {
    border-bottom: solid #777 thin;
    margin: 2rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-2 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-2 {
    margin: 2rem 0 1rem 4rem;
    border-bottom: solid #777 thin;
  }
}

.menu-2-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-1and2 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-3 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-3 {
    margin: 1rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-4 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-4 {
    margin: 1rem 0 1rem 4rem;
  }
}

.menu-4-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-3and4 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-5 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-5 {
    border-bottom: solid #777 thin;
    margin: 2rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-6 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-6 {
    margin: 2rem 0 1rem 4rem;
    border-bottom: solid #777 thin;
  }
}

.menu-6-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-5and6 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-7 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-7 {
    margin: 1rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-8 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-8 {
    margin: 1rem 0 1rem 4rem;
  }
}

.menu-8-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-7and8 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-9 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-9 {
    border-bottom: solid #777 thin;
    margin: 2rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-10 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-10 {
    margin: 2rem 0 1rem 4rem;
    border-bottom: solid #777 thin;
  }
}

.menu-10-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-9and10 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-11 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-11 {
    margin: 1rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-12 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-12 {
    margin: 1rem 0 1rem 4rem;
  }
}

.menu-12-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-11and12 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-13 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-13 {
    border-bottom: solid #777 thin;
    margin: 2rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-14 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-14 {
    margin: 1rem 0 1rem 4rem;
    border-bottom: solid #777 thin;
  }
}

.menu-14-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-13and14 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

.menu-15 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 1rem 4rem 1rem 0rem;
}
@media (min-width: 769px) {
  .menu-15 {
    margin: 1rem 0rem 1rem 0rem;
    padding-bottom: 1rem;
  }
}

.menu-16 {
  display: flex;
  width: 100%;
  justify-content: space-between;
  margin: 0 4 0 0rem;
}
@media (min-width: 769px) {
  .menu-16 {
    margin: 1rem 0 1rem 4rem;
  }
}

.menu-16-1 {
  float: left;
}
@media (min-width: 769px) {
  .menu-15and16 {
    display: flex;
    width: 100%;
    justify-content: space-between;
  }
}

@media (min-width: 769px) {
  img {
    max-width: 100%;
    height: auto;
  }
}

@media (min-width: 769px) {
  .menu-item-2 {
    max-width: 50rem;
    margin: auto;
  }
}

@media (min-width: 769px) {
  .menu-body-2 {
    padding: 0;
    list-style: none;
  }
}

.menu-body-2 li {
  display: inline;
  justify-content: space-between;
  margin-top: 15px;
  margin-right: 7.5px;
}
@media (min-width: 769px) {
  .menu-body-2 li {
    width: calc(100% / 3);
    cursor: pointer;
    width: 24%;
    margin-left: 0;
  }
}

ul#menu-body-2.menu-body-2 {
  margin: 0 8px 30px 0;
  padding: 0;
}
@media (min-width: 769px) {
  ul#menu-body-2.menu-body-2 {
    margin: 0 0 45px 0;
  }
}
@media (max-width: 768px) {
  ul#menu-body-2.menu-body-2 {
    margin: 0 0px 0px 0;
  }
}

.menu-body-2 li:last-child {
  margin-right: 0;
}

.menu-body-bread-1 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .menu-body-bread-1 {
    margin: 0;
  }
}

.menu-body-bread-2 {
  display: flex;
}
@media (min-width: 769px) {
  .menu-body-bread-2 {
    display: flex;
    padding: 0;
    list-style: none;
  }
}

.menu-body-bread-2 li {
  display: inline;
  justify-content: space-between;
  margin-top: 15px;
  margin-right: 7.5px;
  width: calc(100% / 4);
}
@media (min-width: 769px) {
  .menu-body-bread-2 li {
    width: calc(100% / 3);
    cursor: pointer;
    width: 24.5%;
  }
}

ul#menu-body-bread-2.menu-body-bread-2 {
  margin: 0 0 30px 0;
  padding: 0;
}
@media (min-width: 769px) {
  ul#menu-body-bread-2.menu-body-bread-2 {
    margin: 0 0 45px 0;
  }
}

.menu-body-bread-2 li:last-child {
  margin-right: 0;
}

.menu-body-bread-2 li:first-child {
  margin-left: 0;
}

.menu-body-pasta-1 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .menu-body-pasta-1 {
    margin: 0;
  }
}

.menu-body-pasta-2 {
  display: flex;
}
@media (min-width: 769px) {
  .menu-body-pasta-2 {
    display: flex;
    padding: 0;
    list-style: none;
    margin: 0;
    justify-content: space-between;
  }
}

.menu-body-pasta-2 li {
  display: inline;
  justify-content: space-between;
  margin-top: 15px;
  margin-right: 7.5px;
}
@media (min-width: 769px) {
  .menu-body-pasta-2 li {
    width: calc(100% / 3);
    cursor: pointer;
    width: 24%;
    margin-left: 0;
  }
}

ul#menu-body-pasta-2.menu-body-pasta-2 {
  margin: 0 0 30px 0;
  padding: 0;
}
@media (min-width: 769px) {
  ul#menu-body-pasta-2.menu-body-pasta-2 {
    margin: 0 0 45px 0;
  }
}

.menu-body-pasta-2 li:last-child {
  margin-right: 0;
}

.menu-body-sweets-1 {
  display: relative;
  margin: 0 calc(50% - 50vw);
  overflow: hidden;
}
@media (min-width: 769px) {
  .menu-body-sweets-1 {
    margin: 0;
  }
}

.menu-body-sweets-2 {
  display: flex;
}
@media (min-width: 769px) {
  .menu-body-sweets-2 {
    display: flex;
    padding: 0;
    list-style: none;
    margin: 0;
    justify-content: space-between;
  }
}

.menu-body-sweets-2 li {
  display: inline;
  justify-content: space-between;
  margin-top: 15px;
  margin-right: 7.5px;
}
@media (min-width: 769px) {
  .menu-body-sweets-2 li {
    width: calc(100% / 3);
    cursor: pointer;
    width: 24%;
    margin-left: 0;
  }
}

ul#menu-body-sweets-2.menu-body-sweets-2 {
  margin: 0 0 30px 0;
  padding: 0;
}
@media (min-width: 769px) {
  ul#menu-body-sweets-2.menu-body-sweets-2 {
    margin: 0 0 45px 0;
  }
}

.menu-body-sweets-2 li:last-child {
  margin-right: 0;
}

@media (min-width: 769px) {
  .left {
    margin-right: 90px;
  }
}

.right-title {
  display: none;
}
@media (min-width: 769px) {
  .right-title {
    display: block;
    width: 100%;
    margin-top: 0;
    font-family: "Roboto Condensed", sans-serif;
    margin: 0 0 0 0;
    font-size: 24px;
  }
}

.categories {
  display: none;
  padding-left: 3rem;
}
@media (min-width: 769px) {
  .categories {
    display: block;
    padding-left: 0rem;
    margin: 25px 0 36px 0;
  }
  .categories li {
    list-style: none;
    margin: 0 0rem 22px 0rem;
  }
}

@media (min-width: 769px) {
  .categories a {
    color: #b19833;
    font-size: 2rem;
    font-weight: 700;
    line-height: 1;
    margin: 1rem 0rem 1rem 0rem;
  }
}

.li-last {
  padding-bottom: 3rem;
}

/*# sourceMappingURL=style.cs.map */

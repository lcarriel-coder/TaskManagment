import { Link } from "react-router-dom";

export const Footer = () => {
  return (
    <footer>
    

      <div className="footer-content-right">
        <a href="www.facebook.com" >
          <img
            src="https://www.pngfind.com/pngs/m/439-4392840_facebook-link-icon-image-dynamic-spectrum-alliance-pink.png"
            className="icon-style"
            alt="facebook icon"
          />
        </a>
        <a href="www.twitter.com">
          <img
            src="https://www.clipartmax.com/png/middle/203-2036526_a-link-to-twitter-page-twitter-orange-twitter-logo-png.png"
            className="icon-style"
            alt="Twitter icon"
          />
        </a>
        <a href="www.instagram.com">
          <img
            src="https://png.pngtree.com/png-clipart/20180626/ourmid/pngtree-instagram-icon-instagram-logo-png-image_3584853.png"
            className="icon-style"
            alt="Instagram icon"
          />
        </a>
      </div>
    </footer>
  );
};

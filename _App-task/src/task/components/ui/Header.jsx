import { Link } from 'react-router-dom';
import logo from '../../../assets/logo.png';
export const Header = () => {
  return (
    <header className="header-custom">
      <img src={logo} className="profile-small" alt="sports" />
      <h1>Gestion de tareas</h1>
      

      {/* <div >
        <Link to="/contenidos" className="menu" style={{ marginRight: "7px" }}>
          Contenidos
        </Link>

        <Link to="/contadores" className="menu">
          Contadores
        </Link>
      </div> */}
    </header>
  );
};

import * as React from 'react';
import { Container, Nav, Navbar, Offcanvas } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

const NavMenu: React.FC = () => {
    const [showOffcanvas, setShowOffcanvas] = React.useState(false);
    const handleCloseOffcanvas = () => setShowOffcanvas(false);

    const renderOffcanvas = () => {
        return (
            <Navbar.Offcanvas
                show={showOffcanvas}
                onHide={handleCloseOffcanvas}
                id={`offcanvasNavbar`}
                aria-labelledby={`offcanvasNavbarLabel`}
                placement="end"
                style={{ width: '250px' }}
            >
                <Offcanvas.Header closeButton>
                    <Offcanvas.Title id={`offcanvasNavbarLabel`}>
                        Главное меню
                    </Offcanvas.Title>
                </Offcanvas.Header>
                <Offcanvas.Body>
                    <Nav className="justify-content-end flex-grow-1 pe-3">
                        <Nav.Link as={Link} to="/" onClick={() => setShowOffcanvas(false)}>Главная</Nav.Link>
                        <Nav.Link as={Link} to="/counter" onClick={() => setShowOffcanvas(false)}>Счетчик</Nav.Link>
                        <Nav.Link as={Link} to="/fetch-data" onClick={() => setShowOffcanvas(false)}>Получение данных</Nav.Link>
                    </Nav>
                </Offcanvas.Body>
            </Navbar.Offcanvas>
        )
    }

    return (
        <header>
            <Navbar bg="light" expand={'lg'} className="border-bottom box-shadow mb-3">
                <Container>
                    <Navbar.Brand as={Link} to="/">YAGO Fantasy World</Navbar.Brand>
                    <Navbar.Toggle onClick={() => setShowOffcanvas(!showOffcanvas)} />
                    {renderOffcanvas()}
                </Container>
            </Navbar>
        </header>
    );
}

export default NavMenu;

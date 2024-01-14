import './custom.css'

import * as React from 'react';
import { Route, Routes } from 'react-router';
import Layout from './Layout';
import Home from '../pages/Home';
import Counter from '../pages/Counter';
import FetchData from '../pages/FetchData';
import Logout from '../pages/Logout';
import LoginRegister from '../pages/LoginRegisterForm';
import OrganizationList from '../pages/OrganizationList';

export default () => {
    return (
        <Layout>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/counter' element={<Counter />} />
                <Route path='/fetch-data/:startDateIndex?' element={<FetchData />} />
                <Route path='/Logout' element={<Logout />} />
                <Route path='/Register' element={<LoginRegister isLogin={false} />} />
                <Route path='/Login' element={<LoginRegister isLogin={true} />} />
                <Route path='/Organizations' element={<OrganizationList />} />
            </Routes>
        </Layout>
    )
};

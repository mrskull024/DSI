import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import  PerfilEstudiante  from './components/PerfilEstudiante';

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/estudiante',
        element: <PerfilEstudiante />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    }
];

export default AppRoutes;

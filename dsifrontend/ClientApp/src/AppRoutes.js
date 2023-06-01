import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import PerfilEstudiante from './components/PerfilEstudiante';
import Horario from './components/Horario';

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
        path: '/horario',
        element: <Horario />
    }
];

export default AppRoutes;

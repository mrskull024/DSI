//import { Counter } from "./components/Counter";
//import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import PerfilEstudiante from './components/PerfilEstudiante';
import Horario from './components/Horario';
import Pagos from './components/Pagos';
import AsignaturasPorEstudiante from './components/AsignaturasPorEstudiante';

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
        path: '/asignaturas',
        element: <AsignaturasPorEstudiante />
    },
    {
        path: '/pagos',
        element: <Pagos />
    },
    {
        path: '/horario',
        element: <Horario />
    }
];

export default AppRoutes;

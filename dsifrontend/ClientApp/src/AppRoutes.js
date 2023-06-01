import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import PerfilEstudiante from './components/PerfilEstudiante';
import Horario from './components/Horario';
import Pagos from "./components/Pagos";
import ListaEstudiantes from "./components/ListaEstudiantes";

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
    },
    {
        path: '/listaestudiantes',
        element: <ListaEstudiantes />
    },
    {
        path: '/pagos',
        element: <Pagos />
    }
];

export default AppRoutes;

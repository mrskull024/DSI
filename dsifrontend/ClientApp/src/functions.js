import Swal from 'sweetalert2';
import withReactContent from 'sweetalert2-react-content';

export function show_alert(message, icon, focus) {
    on_focus(focus);
    const MySwal = withReactContent(Swal);
    MySwal.fire({
        title: message,
        icon: icon
    });
}

function on_focus(focus) {
    if (focus !== '') {
        document.getElementById(focus).focus();
    }
}
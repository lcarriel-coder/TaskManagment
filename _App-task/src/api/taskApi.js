import axios from 'axios';
const VITE_API_URL = "https://localhost:7236/api"

const taskApi = axios.create({
    baseURL: VITE_API_URL
});

// //Todo : configurar interceptores
// taskApi.interceptors.request.use(config => {
//     config.headers = {
//         ...config.headers,
//         'x-token': localStorage.getItem('token')
//     }
//     return config;
// });


export default taskApi;
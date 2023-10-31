import { configureStore } from '@reduxjs/toolkit';
import { taskSlice } from './task/taskSlice';
import { uiSlice } from './ui/uiSlice';





export const store = configureStore({
    reducer: {
        task: taskSlice.reducer,
        ui: uiSlice.reducer
       
    },
})
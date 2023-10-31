import { createSlice } from '@reduxjs/toolkit';


const initialState = {
    isLoadingTask: true,
    tasks: [],
    activeTask: null,
    pageSize: 30,
    totalRecords:0,
   
}
export const taskSlice = createSlice({
    name: 'task',
    initialState,
    reducers: {
        onSetActiveTask: (state, { payload }) => {
            state.activeTask = payload;
        },
        onAddNewTask: (state, { payload }) => {
            state.tasks.push(payload);
            state.activeTask = null;
        },
        onUpdateTask: (state, { payload }) => {
            state.tasks = state.tasks.map(task => {
                if (task.taskId === payload.taskId) {
                    return payload;
                }

                return task;
            });
        },
        onDeleteTask: (state, { payload }) => {
            console.log(payload,state.tasks);
            // if (state.activeTask) {
                state.tasks = state.tasks.filter(task => task.taskId !== payload?.taskId);
                //state.activeEvent = null;
            // }
        },
        onLoadingTasks: (state, { payload = [] }) => {
            state.isLoadingTask = false;

            state.tasks = payload?.tasks;
            state.totalPages = payload?.totalPages;
            state.totalRecords = payload?.totalRecords;
            
        },

     
        onLoading: (state, { payload }) => {
            state.isLoadingTask = true;
        },
       
        
      

    },
})

// Action creators are generated for each case reducer function
export const { onSetActiveTask, onAddNewTask,onUpdateTask ,onDeleteTask,onLoadingTasks,onSetPage,onLoading,onSetFilter } = taskSlice.actions;

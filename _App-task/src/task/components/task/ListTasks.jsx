import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
// import { SlidesItem } from "./SlidesItem";
import Slider from "react-slick";
import { Loader } from "../../../utils/Loader";
import {  toast } from 'react-toastify';
import { Task } from "./Task";
import { Box, Divider, Grid, InputAdornment,OutlinedInput,TablePagination } from "@mui/material";
import { useTaskStore, useUiStore } from "../../../hooks";
import { TaskModal } from "../modal/TaskModal";
import { AddNew } from "./AddNew";
import ControlTyping from "../../../utils/ControlTyping";
import { styled } from '@mui/material/styles';
import { FilterCategory } from "./FilterCategory";





export const ListTasks = () => {
  
  const { openDateModal } = useUiStore();
  const { tasks, startLoadingTasks ,isLoadingTask, totalRecords,pageSize } = useTaskStore();

  const [pageNumber, setPageNumber] = useState(0);

  const setPageHandle = (event, newPage) => {
    setPageNumber(parseInt(newPage));
    const obj = {
      UserId: "9411b400-11c1-4c6b-82a3-a73dd8347b63",
      PageNumber: parseInt(newPage),
    };
    startLoadingTasks({ obj });
  };


  useEffect(() => {
    const obj ={
      UserId: "9411b400-11c1-4c6b-82a3-a73dd8347b63",
      PageNumber: 0,
    }
    startLoadingTasks({obj});
  }, []);



  return (
    <>
      <AddNew openDateModal={openDateModal} />

      <Divider  variant="middle"/>
      
      <FilterCategory pageNumber={pageNumber}/>

      {isLoadingTask ? (
        <Loader />
      ) : (
        <>
          <Grid
            container
            spacing={2}
          >
            {tasks?.map((item) => (
              <Task
                key={item?.taskId}
                data={item}
                openDateModal={openDateModal}
              />
            ))}
          </Grid>

          <TablePagination
            rowsPerPageOptions={[20]}
            component="div"
            count={totalRecords}
            rowsPerPage={pageSize}
            page={pageNumber}
            onPageChange={setPageHandle}
        
          />
        </>
      )}

      <TaskModal />
    </>
  );
};

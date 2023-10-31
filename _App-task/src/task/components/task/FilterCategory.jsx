import { Grid,FormControl,InputLabel,Select,MenuItem   } from "@mui/material";
import { useTaskStore } from "../../../hooks";

export const FilterCategory = ({pageNumber}) => {
  const { startLoadingTasks ,categories } = useTaskStore();


  const onInputChanged = (event) => {
   
    const { value } = event.target;

    const obj ={
      PageNumber:pageNumber,
      Filter:value?.toString()
    }
    startLoadingTasks({obj})
  };



  return (
    <>
      <Grid container  mt={3} mb={3}>
        <Grid item xs={12} md={6}>
          <FormControl sx={{ m: 1, minWidth: 120 }} fullWidth>
            <InputLabel id="demo-controlled-open-select-label">
              Categoría
            </InputLabel>
            <Select
           
              label="Categoría"
              onChange={onInputChanged}
            >

            {categories?.map((category ) => {
                 return <MenuItem value={category?.name}>{category?.name}</MenuItem>
              })}


             
            </Select>
          </FormControl>
        </Grid>
      </Grid>
    </>
  );
};

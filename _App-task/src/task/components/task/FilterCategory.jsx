import { Grid,FormControl,InputLabel,Select,MenuItem   } from "@mui/material";
import { useTaskStore } from "../../../hooks";

export const FilterCategory = ({pageNumber}) => {
  const { startLoadingTasks,setFilter } = useTaskStore();

 
  const onInputChanged = (event) => {
    const { value } = event.target;

    const obj ={
      UserId: "9411b400-11c1-4c6b-82a3-a73dd8347b63",
      PageNumber:pageNumber,
      Filter:value
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
              <MenuItem value="Personal">
                Personal
              </MenuItem>
              <MenuItem value="Familia">
                Familia
              </MenuItem>
              <MenuItem value="Trabajo">
                Trabajo
              </MenuItem>
            </Select>
          </FormControl>
        </Grid>
      </Grid>
    </>
  );
};

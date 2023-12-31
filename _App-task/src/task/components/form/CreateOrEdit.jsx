import { useMemo, useState, useEffect } from "react";
import {
    Button,
    Checkbox,
    FormControl,
    Select,
    MenuItem,
    FormControlLabel,
    InputLabel,
    Grid,
    TextField,
  } from "@mui/material";
import { useTaskStore } from "../../../hooks";
import { format } from 'date-fns';




export const CreateOrEdit = ({closeDateModal }) => {

    const { startSavingTask ,categories } = useTaskStore();
    const [formSubmitted, setFormSubmitted] = useState(false);

    const { activeTask } = useTaskStore();



    const [formValues, setFormValues] = useState({
      description: "",
      deadlineToFinish: new Date(),
      isCompleted: false,
      categoryId: "",
    });

    const onInputChanged = (event) => {
        const { name, type, value, checked } = event.target;
      
        setFormValues((prevFormValues) => {
          return {
            ...prevFormValues,
            [name]: type === 'checkbox' ? checked : value,
          };
        });
      };

      
      const onSubmit = async (event) => {
        event.preventDefault();
        setFormSubmitted(true);
    
        await startSavingTask({...formValues, categoryName: categories?.find(e=>e.categoryId === formValues.categoryId)?.name});
        closeDateModal();
        setFormSubmitted(false);
      };


      useEffect(() => {
        if (activeTask !== null) {
          setFormValues({ ...activeTask });
        }
      }, [activeTask]);




  return (
    <form className="" onSubmit={onSubmit}>
    <Grid container spacing={2}>
      <Grid item md={12} mt={2}>
        <TextField
          fullWidth
          name="description"
          label="Descripción"
          value={formValues.description}
          onChange={onInputChanged}
        />
      </Grid>

      <Grid item md={12}>
        <TextField
          fullWidth
          type="date"
          name="deadlineToFinish"
          label="Fecha limite"
          value={formValues?.deadlineToFinish ? format(new Date(formValues.deadlineToFinish), 'yyyy-MM-dd') : new Date()}
          onChange={onInputChanged}
        />
      </Grid>
      <Grid item md={12}>
        <FormControlLabel
          label="¿Está completado?"
          control={
            <Checkbox
            fullWidth
              name="isCompleted"
              checked={formValues.isCompleted}
              onChange={onInputChanged}
              inputProps={{ "aria-label": "controlled" }}
            />
          }
        />
      </Grid>

      <Grid item md={12}>
        <FormControl sx={{ m: 1, minWidth: 120 }} fullWidth>
          <InputLabel id="demo-controlled-open-select-label">
            Categoría
          </InputLabel>
          <Select
          
            name="categoryId"
            value={formValues.categoryId}
            label="Categoría"
            onChange={onInputChanged}
          >
              {categories?.map((category ) => {
                 return <MenuItem value={category?.categoryId}>{category?.name}</MenuItem>
              })}
 
          </Select>
        </FormControl>
      </Grid>

      <Grid item md={12}>
        <Button
          type="submit"
          variant='contained'
          className="btn btn-outline-primary btn-block"
          sx={{marginRight:'15px'}}
        >
          <i className="far fa-save"></i>
          <span> Guardar</span>
        </Button>

        <Button
         variant='outlined'
         onClick={closeDateModal} 
          className="btn btn-outline-primary btn-block"
        >
          <i className="far fa-save"></i>
          <span> Cerrar</span>
        </Button>
      </Grid>
    </Grid>
  </form>
  )
}

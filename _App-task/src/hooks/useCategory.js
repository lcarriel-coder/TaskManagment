import { useEffect } from 'react';
import { useState } from 'react';
import { taskApi } from '../api';
import { useDispatch } from 'react-redux';
import { onSetCategories } from '../store';

export const useCategory = () => {
    const dispatch = useDispatch();
    const [loading, setLoading] = useState(true);

   
    const getData = async() =>{

        const { data } = await taskApi.get(`/Category`);

        dispatch(onSetCategories(data));
       

        setLoading(false);
    }

    useEffect(() => {
     
     getData();

    }, []);



           
  return {
    loading,


  }
}

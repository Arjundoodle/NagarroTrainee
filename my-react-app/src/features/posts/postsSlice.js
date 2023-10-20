import { createSlice } from "@reduxjs/toolkit";

const initialState=[
   {id:'1',title:'Learning Redux toolkit ',content:'I have heard good things'},
   {id:'2',title:'Learning React ',content:'It is interesting'}
]

 const postSlice=createSlice({
    name:'posts',
    initialState,
    reducers:{
        postadded(state,action){
            state.push(action.payload)
        },
        
        
    }
})

export const selectAllPosts=(state)=>state.posts;
export const {postadded}=postSlice.actions
export const postsReducer= postSlice.reducer;


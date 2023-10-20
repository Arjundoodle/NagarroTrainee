import { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { nanoid } from "@reduxjs/toolkit";
import { postadded } from "./postsSlice";

const Addform=()=>{
    const dispatch = useDispatch()

    const [title, setTitle] = useState('')
    const [content, setContent] = useState('')
  

    

    const onTitleChanged = e => setTitle(e.target.value)
    const onContentChanged = e => setContent(e.target.value)
  

    const onSavePostClicked = () => {
        if (title && content) {
            dispatch(
                postadded({title, content,id:nanoid})
            )
            setTitle('')
            setContent('')
        }
    }

    const canSave = Boolean(title) && Boolean(content)

    

    return (
        <section>
            <h2>Add a New Post</h2>
            <form>
                <label htmlFor="postTitle">Post Title:</label>
                <input
                    type="text"
                    id="postTitle"
                    name="postTitle"
                    value={title}
                    onChange={onTitleChanged}
                />
                
                <label htmlFor="postContent">Content:</label>
                <textarea
                    id="postContent"
                    name="postContent"
                    value={content}
                    onChange={onContentChanged}
                />
                <button
                    type="button"
                    onClick={onSavePostClicked}disabled={!canSave}
                   
                >Save Post</button>
            </form>
        </section>
    )

}

export default  Addform
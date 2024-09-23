import { FETCH_POSTS, ADD_POST } from '../actions/postActions';

const initialState = {
    items: [],
};

const postReducer = (state = initialState, action) => {
    switch (action.type) {
        case FETCH_POSTS:
            return { ...state, items: action.payload };
        case ADD_POST:
            return { ...state, items: [...state.items, action.payload] };
        default:
            return state;
    }
};

export default postReducer;

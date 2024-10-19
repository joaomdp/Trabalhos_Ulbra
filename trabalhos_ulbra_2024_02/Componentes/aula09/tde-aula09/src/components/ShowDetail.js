import { useState } from 'react';
function ShowDetail({description}) {
    const [enable, setEneable] = useState(false)

    function handleClickEnableDetails() {
        setEneable(!enable)
    }

    return (
        <div>
            {enable && <p>{description}</p>}
            <button onClick={handleClickEnableDetails}> 
            {enable ? "Hide" : "Show"}details</button>
        </div>
    )
}

export default ShowDetail;
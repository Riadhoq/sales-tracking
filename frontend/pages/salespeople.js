import { Flex } from "@chakra-ui/react";
import Salesperson from "../components/Salesperson";

export default function Salespeople({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      {data.map((salesperson) => (
        <Salesperson key={salesperson.salespersonId} data={salesperson} />
      ))}
    </Flex>
  );
}

Salespeople.getInitialProps = async (ctx) => {
  const res = await fetch("http://localhost:5000/api/salespeople");
  const data = await res.json();
  return { data };
};

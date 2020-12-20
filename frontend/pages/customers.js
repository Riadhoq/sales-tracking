import { Flex } from "@chakra-ui/react";
import Customer from "../components/Customer";

export default function Salespeople({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      {data.map((c) => (
        <Customer key={c.customerId} data={c} />
      ))}
    </Flex>
  );
}

Salespeople.getInitialProps = async (ctx) => {
  const res = await fetch("http://localhost:5000/api/customers");
  const data = await res.json();
  return { data };
};
